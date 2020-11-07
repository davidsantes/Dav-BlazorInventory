using Business.Interfaces;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class WarehouseService : ICrudDataService<WarehouseEntity>
    {
        public List<WarehouseEntity> ItemList()
        {
            using (var db = new InventoryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateItem(WarehouseEntity item)
        {
            using (var db = new InventoryContext())
            {
                db.Warehouses.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateItem(WarehouseEntity item)
        {
            using (var db = new InventoryContext())
            {
                db.Warehouses.Update(item);
                db.SaveChanges();
            }
        }
    }
}
