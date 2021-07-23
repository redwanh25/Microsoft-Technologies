using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

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

            //CustomerRepository repo = new CustomerRepository();
            //Customer customer = repo.GetCutomerById(2);
            //customer.ContactNo = "01767409798";
            //Console.WriteLine(customer.CustomerName);
            //Console.WriteLine(customer.Address);

            //ProductRepository repo = new ProductRepository();


            //customer.Address = "437/3, Senpara Parbata, Mirpur-10";

            //bool isSaved = repo.AddCutomer(customer);
            //bool isSaved = repo.UpdateCutomer(customer);
            //bool isSaved = repo.DeleteCustomer(customer);
            //if (isSaved)
            //{
            //    Console.WriteLine("Saved!");
            //}

            //===================================================================

            CategoryRepository repo = new CategoryRepository();
            List<Category> categories = repo.GetAllCategory();
            repo.LoadProduct(categories);

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
