using BLL_BusinessLogicLayer;
using BLL_BusinessLogicLayer.Contracts;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DatabaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerManager _customerManager;

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        public IActionResult Index()
        {
            List<VMCustomer> list = _customerManager.GetCustomerListFromView();
            return View(list);
        }

        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                Customer customer1 = _customerManager.GetById(2);
                bool isSaved = _customerManager.Add(customer);
            }
            return View();
        }
    }
}
