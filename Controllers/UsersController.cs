using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.WebPages;
using BusinessLogic_MF;
using Repository_Mf_Hub;
using Services_MF;

namespace Mf_Hub.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;
        private readonly IUserLogic _userLogic;
        
        public UsersController(IUserService userService, IUserLogic userLogic)
        {
            _userService = userService;
            _userLogic = userLogic;
        }
        // GET api/values
        public IEnumerable<User> Get()
        {
            return _userService.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]User value)
        {
            var user = _userLogic.CompleteUser(value);
            var result =_userService.SaveUser(user);
        }


        [Route("api/users/ValidateUser/")]
        public string PostValidateUser([FromBody]User values)
        {
            var user = _userService.RetrieveUser(values.Name);
            return _userLogic.ValidateUser(values.PasswordHash, user);
        }
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
