using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using DAL_DataAccessLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_DataAccessLayer.Contracts;

namespace DAL_DataAccessLayer
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public override List<Product> GetAll()
        {
            return db.Products.Include(c => c.Category).ToList();
        }
    }
}
