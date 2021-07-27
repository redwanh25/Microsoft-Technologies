﻿using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        CustomerDbContext db = new CustomerDbContext();

        public Category GetCategoryById(int id)
        {
            Category category = db.Categories.Find(id);
            return category;
        }
        public override List<Category> GetAll()
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
    }
}