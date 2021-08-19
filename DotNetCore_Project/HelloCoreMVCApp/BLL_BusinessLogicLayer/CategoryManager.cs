using BLL_BusinessLogicLayer.Base;
using BLL_BusinessLogicLayer.Contracts;
using DAL_DataAccessLayer.Contracts;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer
{
    public class CategoryManager : Manager<Category>, ICategoryManager
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
    }
}
