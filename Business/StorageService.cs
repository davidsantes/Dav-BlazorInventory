using Business.Interfaces;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class StorageService : ICrudDataService<StorageEntity>
    {
        public List<StorageEntity> ItemList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
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
