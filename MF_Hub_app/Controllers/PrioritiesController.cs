using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repository_Mf_Hub;
using Services_MF;

namespace Mf_Hub.Controllers
{
    public class PrioritiesController : ApiController
    {
        private readonly IPriorityService _priorityService;

        public PrioritiesController(IPriorityService priorityService)
        {
            _priorityService = priorityService;
        }
        // GET: api/Priorities
        public IEnumerable<Priority> Get()
        {
            return _priorityService.GetPriorities();
        }

        // GET: api/Priorities/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Priorities
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Priorities/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Priorities/5
        public void Delete(int id)
        {
        }
    }
}
