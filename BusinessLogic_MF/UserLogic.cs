using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Repository_Mf_Hub;

namespace BusinessLogic_MF
{
    public class UserLogic : IUserLogic
    {
        private String CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);

        }

        private String GenerateSHA256Hash(String input, String salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sha256HashString = new SHA256Managed();
            byte[] hash = sha256HashString.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }


        private List<string> GeneratePassword(String input, int saltSize)
        {
            List<string> saltHash = new List<string>();
            string salt = CreateSalt(saltSize);

            string pass = GenerateSHA256Hash(input, salt);

            saltHash.Add(salt);
            saltHash.Add(pass);
            return saltHash;
        }

        public User CompleteUser(User user)
        {
            List<string> passHashed = GeneratePassword(user.PasswordHash, 36);
            user.SecuritySalt = passHashed[0];
            user.PasswordHash = passHashed[1];
            return user;
        }

        public bool ValidateUser(string pass, User user)
        {
            string passHashed = GenerateSHA256Hash(pass, user.SecuritySalt);
            return user.PasswordHash == passHashed ? true : false;
        }
    }
}
