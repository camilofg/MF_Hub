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
    [AllowAnonymous]
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

        public void Post([FromBody]User value)
        {
            var user = _userLogic.CompleteUser(value);
            var result =_userService.SaveUser(user);
        }

        [Route("api/users/ValidateUser/")]
        public IHttpActionResult PostValidateUser([FromBody]User values)
        {
            var user = _userService.RetrieveUser(values.Name);
            if (_userLogic.ValidateUser(values.PasswordHash, user))
            {
                var token = TokenGenerator.GenerateTokenJwt(user.Name);
                return Ok(token);
            }
            return Unauthorized();
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
