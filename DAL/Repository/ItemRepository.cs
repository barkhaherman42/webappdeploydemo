using System.Collections.Generic;
using System.Linq;
namespace DAL.Repository
{
    public class ItemRepository
    {
        MVC_EF_DbFirstEntities entity = new MVC_EF_DbFirstEntities();

        public List<Item> getItems()
        {
            List<Item> lstObj = new List<Item>();
            var result = (from item in entity.Items
                          select new
                          {
                              item.Item_Name,
                              item.Item_Price,
                          }).ToList();

            foreach (var item in result)
            {
                Item item1 = new Item();

                item1.Item_Name = item.Item_Name;
                item1.Item_Price = item.Item_Price;

                lstObj.Add(item1);
            }

            return lstObj;
        }

    }
}
