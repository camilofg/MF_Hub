using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Mf_Hub;

namespace Services_MF
{
    public interface IItemService
    {
        Item GetItemById(int itemId);   
        IEnumerable<Item> GetUserItems(int userId);
        Item CreateItem(Item item);
        Item UpdateItem(Item item);
        void DeleteItem(int itemId);
    }
}
