using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class ProductRepository
    {
        CustomerDbContext db = new CustomerDbContext();

        public Product GetProductById(int id)
        {
            Product product = db.Products.Find(id);
            return product;
        }
        public List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }

        public bool AddProduct(Product product)
        {
            //db.Products.Add(product);
            db.Entry(product).State = EntityState.Added;
            return db.SaveChanges() > 0;
        }

        public bool UpdateProduct(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool DeleteProduct(Product product)
        {
            db.Entry(product).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
    }
}
