using BLL_BusinessLogicLayer.Base;
using BLL_BusinessLogicLayer.Contracts;
using DAL_DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer
{
    public class ProductManager : Manager<Product>, IProductManager
    {
        public ProductManager() : base(new ProductRepository())
        {

        }

        public List<Product> GetByYear(int year)
        {
            throw new NotImplementedException();
        }
    }
}
