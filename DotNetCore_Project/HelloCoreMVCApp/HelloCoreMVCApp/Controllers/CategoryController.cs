using BLL_BusinessLogicLayer.Contracts;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMVCApp.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                Category category1 = _categoryManager.GetById(2);
                bool isSaved = _categoryManager.Add(category);
            }
            return View();
        }
    }
}
