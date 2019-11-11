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
    public class ItemsController : ApiController
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [Route("api/items/GetByUser/")]
        public IEnumerable<Item> PostItemsByUser([FromBody]int userId)
        {
            return _itemService.GetUserItems(userId);
        }

        // GET: api/Items/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Items
        public void Post([FromBody]Item item)
        {
            _itemService.CreateItem(item);
        }

        // PUT: api/Items/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Items/5
        public void Delete(int id)
        {
        }
    }
}
