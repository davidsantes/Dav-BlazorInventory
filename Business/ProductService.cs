using Business.Interfaces;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class ProductService : ICrudDataService<ProductEntity>
    {
        public List<ProductEntity> ItemList()
        {
            using (var db = new InventoryContext())
            {
                return db.Products.ToList();
            }
        }

        public void CreateItem(ProductEntity item)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateItem(ProductEntity item)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Update(item);
                db.SaveChanges();
            }
        }
    }
}
