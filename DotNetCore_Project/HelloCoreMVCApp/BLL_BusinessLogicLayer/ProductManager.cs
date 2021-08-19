using BLL_BusinessLogicLayer.Base;
using BLL_BusinessLogicLayer.Contracts;
using DAL_DataAccessLayer;
using DAL_DataAccessLayer.Contracts;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer
{
    public class ProductManager : Manager<Product>, IProductManager
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetByYear(int year)
        {
            throw new NotImplementedException();
        }
    }
}
