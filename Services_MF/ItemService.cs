using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Mf_Hub;

namespace Services_MF
{
    public class ItemService : IItemService
    {
        private readonly Mf_Hub_model _context;

        public ItemService(Mf_Hub_model context)
        {
            _context = context;
        }
        public Item GetItemById(int id)
        {
            return _context.Items.Find(id);
        }

        public IEnumerable<Item> GetUserItems(int userId)
        {
            return _context.Items.Where(x => x.UserId == userId).Include(x => x.Status).Include(x => x.Priority);
        }

        public Item CreateItem(Item item)
        {
            var time = _context.Priorities.Find(item.PriorityId)?.MaxTime;
            if (time != null)
            {
                double maxTime = (double)time;
                item.Dateline = DateTime.Now.AddHours(maxTime);
            }

            item.CreationDate = DateTime.Now;
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Item UpdateItem(Item item)
        {
            Item itm = _context.Items.Find(item.ItemId);
            itm = item;
            _context.SaveChanges();
            return item;
        }

        public void DeleteItem(int id)
        {
            var item = _context.Items.Find(id);
            if (item != null)
                _context.Items.Remove(item);
        }
    }
}
