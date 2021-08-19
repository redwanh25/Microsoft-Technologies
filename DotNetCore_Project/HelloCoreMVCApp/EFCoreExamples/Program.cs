using Models;
using DAL_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using BLL_BusinessLogicLayer;
using DAL_DataAccessLayer.Contracts;

namespace EFCoreExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer()
            //{
            //    CustomerName = "Redwan Hossain",
            //    Address = "Dhaka"
            //    ContactNo = "01767409798"
            //};

            //Product product = new Product()
            //{
            //    Name = "LG Monitor",
            //    Price = 19000,
            //    Description = "20 inch Monitor"
            //};

            //Category category = new Category()
            //{
            //    Code = "001",
            //    Name = "Electronics"
            //};

            //product.Category = category;

            //IProductRepository productRepository = new ProductRepository();
            //bool isSaved = productRepository.Add(customer);
            //if (isSaved)
            //{
            //    Console.WriteLine("Saved!");
            //}

            //===================================================================

            ICategoryRepository categoryRepository = new CategoryRepository();
            List<Category> categories = categoryRepository.GetAll();
            categoryRepository.LoadProduct(categories);

            if (categories != null && categories.Any())
            {
                foreach(var category in categories)
                {
                    Console.WriteLine("Category: " + category.Name + " Code: " + category.Code);
                    if (category.Products != null && category.Products.Any())
                    {
                        Console.WriteLine("\t Product List: ");
                        foreach (var product in category.Products)
                        {
                            Console.WriteLine("\t\t Product: " + product.Name + "; Price : " + product.Price);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\t No Product Available!");
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
