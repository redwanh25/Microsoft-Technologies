using BLL_BusinessLogicLayer;
using BLL_BusinessLogicLayer.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private ICategoryManager _categoryManager;

        public ProductController(IProductManager productManager, ICategoryManager categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            List<Product> listofProducts = _productManager.GetAll();
            return View(listofProducts);
        }

        public IActionResult Create()
        {
            List<SelectListItem> categoryItemList = _categoryManager.GetAll().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            var model = new Product();
            model.CategoryItemList = categoryItemList;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                bool isSaved = _productManager.Add(product);
                if (isSaved)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }
    }
}
