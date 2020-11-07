using Business.Interfaces;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class InputOutputService : ICrudDataService<InputOutputEntity>
    {
        public List<InputOutputEntity> ItemList()
        {
            using (var db = new InventoryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateItem(InputOutputEntity item)
        {
            using (var db = new InventoryContext())
            {
                db.InOuts.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateItem(InputOutputEntity item)
        {
            using (var db = new InventoryContext())
            {
                db.InOuts.Update(item);
                db.SaveChanges();
            }
        }
    }
}
