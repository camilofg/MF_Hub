using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repository_Mf_Hub;

namespace Services_MF
{
    public interface IUserService
    {
        //List<Repository.UsersQuery_Result> GetUsers(string FilterAccess, string FilterRol);

        string PostRole(string description);
        string PostAccess(string description);
        string SaveUser(User user);
        string PostAccessXRole(string access, string role);
        List<Profile> GetProfiles();
        string DeleteUser(int userID);
        User RetrieveUser(string name);
        User GetById(object id);
        IEnumerable<User> GetAll();
        IEnumerable<User> Query(Expression<Func<User, bool>> filter);
        void Add(User entity);
        void Remove(User entity);
    }
}
