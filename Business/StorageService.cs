using Business.Interfaces;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class StorageService : ICrudDataServiceStorage<StorageEntity>
    {
        public List<StorageEntity> ItemList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
            }
        }

        public List<StorageEntity> ItemListByWarehouse(string idWarehouse)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.Warehouse)
                    .Where(s => s.WarehouseId == idWarehouse)
                    .ToList();
            }
        }

        public StorageEntity ItemById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList().LastOrDefault(item => item.StorageId == id);
            }
        }

        public void CreateItem(StorageEntity item)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Add(item);
                db.SaveChanges();
            }
        }

        public bool IsProductInWarehouse(string idStorage)
        {
            using (var db = new InventoryContext())
            {
                var product = db.Storages.ToList()
                    .Where(s => s.StorageId == idStorage);

                return product.Any();
            }
        }

        public void UpdateItem(StorageEntity item)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Update(item);
                db.SaveChanges();
            }
        }
    }
}
