using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repository_Mf_Hub;

namespace Services_MF
{
    public class UserService : IUserService
    {
        private readonly Mf_Hub_model _context;

        public UserService(Mf_Hub_model context)
        {
            _context = context;
        }

        public string PostRole(string description)
        {
            throw new NotImplementedException();
        }

        public string PostAccess(string description)
        {
            throw new NotImplementedException();
        }

        public string SaveUser(User user)
        {
            if (!_context.Users.Any(x => x.Name == user.Name || x.Email == user.Email))
            {
                try
                {
                    //Creation of users by the api are only users not admin.
                    user.ProfileId = 2;
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    return "User saved";
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }

            return "The user already exists";

        }

        public string PostAccessXRole(string access, string role)
        {
            throw new NotImplementedException();
        }

        public List<Profile> GetProfiles()
        {
            throw new NotImplementedException();
        }

        public string DeleteUser(int userID)
        {
            throw new NotImplementedException();
        }

        public User RetrieveUser(string name)
        {
            return _context.Users.FirstOrDefault(x => x.Name == name);
        }

        public User GetById(object id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public IEnumerable<User> Query(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

    }
}
