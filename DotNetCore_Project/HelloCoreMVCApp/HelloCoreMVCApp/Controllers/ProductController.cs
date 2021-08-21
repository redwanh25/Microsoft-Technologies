using AutoMapper;
using BLL_BusinessLogicLayer;
using BLL_BusinessLogicLayer.Contracts;
using HelloCoreMVCApp.Models.ProductViewModel;
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
        private IMapper _mapper;
        public ProductController(IProductManager productManager, ICategoryManager categoryManager, IMapper mapper)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<Product> products = _productManager.GetAll();
            List<ProductListVM> productList = _mapper.Map<List<ProductListVM>>(products);
            return View(productList);
        }

        public IActionResult Create()
        {
            List<SelectListItem> categoryItemList = _categoryManager.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            ProductCreateVM model = new ProductCreateVM();
            model.CategoryItemList = categoryItemList;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ProductCreateVM model)
        {
            if (ModelState.IsValid)
            {
                Product product = _mapper.Map<Product>(model);
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
