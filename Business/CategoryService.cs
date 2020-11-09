using Business.Interfaces;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class CategoryService : ICrudDataService<CategoryEntity>
    {
        public List<CategoryEntity> ItemList()
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList();
            }
        }

        public CategoryEntity ItemById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList().LastOrDefault(item => item.CategoryId == id);
            }
        }

        public void CreateItem(CategoryEntity item) {
            using (var db = new InventoryContext())
            {
                db.Categories.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateItem(CategoryEntity item) {
            using (var db = new InventoryContext())
            {
                db.Categories.Update(item);
                db.SaveChanges();
            }
        }
    }
}
