using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Repository_Mf_Hub;
using Services_MF;

namespace Mf_Hub.Controllers
{
    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class StatusController : ApiController
    {
        private readonly IStatusService _statusService;
        
        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }
        // GET: api/Status
        public IEnumerable<Status> Get()
        {
            return _statusService.GetStatus();
        }

        // GET: api/Status/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Status
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Status/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Status/5
        public void Delete(int id)
        {
        }
    }
}
