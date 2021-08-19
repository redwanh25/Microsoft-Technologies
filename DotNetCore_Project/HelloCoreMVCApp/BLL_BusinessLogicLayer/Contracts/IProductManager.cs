using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer.Contracts
{
    public interface IProductManager
    {
        public Product GetById<Y>(Y id);
        public List<Product> GetAll();
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        List<Product> GetByYear(int year);
    }
}
