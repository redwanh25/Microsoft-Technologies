using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_DataAccessLayer.Contracts
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void LoadProduct(List<Category> categories);
    }
}
