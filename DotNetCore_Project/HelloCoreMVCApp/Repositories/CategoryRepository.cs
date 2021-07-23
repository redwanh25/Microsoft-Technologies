using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class CategoryRepository
    {
        CustomerDbContext db = new CustomerDbContext();

        public Category GetCategoryById(int id)
        {
            Category category = db.Categories.Find(id);
            return category;
        }
        public List<Category> GetAllCategory()
        {
            //Eager Loading
            //return db.Categories.Include(c => c.Products).ToList();

            //Eager Loading
            //return db.Categories
            //    .Include(c => c.Products)
            //        .ThenInclude(p => p.XYZ)
            //    .Include(c => c.Products)
            //    .Include(c => c.Products)
            //    .ToList();

            return db.Categories.ToList();
        }

        //Explicit Loading
        public void LoadProduct(List<Category> categories)
        {
            foreach(Category category in categories)
            {
                //Explicit Loading Shob category tule ene product theke filter kore then shei product gulo show korano jay. Jeta nicher line a kora hoise.
                //But, Eager loading a ai shubidha ta nai.

                db.Entry(category).Collection(c => c.Products).Query().Where(p => p.IsActive == true).Load();
                //db.Entry(category).Collection(c => c.Order).Query().Where(o => o.OrderNo == "123").Load();
            }
        }

        public bool AddCategory(Category category)
        {
            db.Entry(category).State = EntityState.Added;
            return db.SaveChanges() > 0;
        }

        public bool UpdateCategory(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool DeleteCategory(Category category)
        {
            db.Entry(category).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
    }
}
