using Business.Interfaces;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
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

        public ProductEntity ItemById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Products.ToList().LastOrDefault(item => item.ProductId == id);
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
