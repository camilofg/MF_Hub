using Repository_Mf_Hub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_MF
{
    public interface IUserLogic
    {
        User CompleteUser(User user);
        bool ValidateUser(string pass, User user);
    }
}
