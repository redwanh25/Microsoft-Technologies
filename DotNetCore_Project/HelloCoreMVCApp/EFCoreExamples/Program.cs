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

            CustomerRepository repo1 = new CustomerRepository();
            Customer customer = repo1.GetById(2);
            customer.ContactNo = "01767409798";
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.Address);

            Console.WriteLine();

            //ProductRepository repo = new ProductRepository();


            //customer.Address = "437/3, Senpara Parbata, Mirpur-10";

            //bool isSaved = repo.Add(customer);
            //bool isSaved = repo.Update(customer);
            //bool isSaved = repo.Delete(customer);
            //if (isSaved)
            //{
            //    Console.WriteLine("Saved!");
            //}

            //===================================================================

            CategoryRepository repo = new CategoryRepository();
            List<Category> categories = repo.GetAll();
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
