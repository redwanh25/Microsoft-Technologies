using BLL_BusinessLogicLayer;
using BLL_BusinessLogicLayer.Base;
using BLL_BusinessLogicLayer.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMVCApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductManager _productManager;

        public ProductController()
        {
            _productManager = new ProductManager();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                Product product1 = _productManager.GetById(2);
                bool isSaved = _productManager.Add(product);
            }
            return View();
        }
    }
}
