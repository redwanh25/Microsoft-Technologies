using Models;
using Repositories;
using System;

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
            //};

            CustomerRepository repo = new CustomerRepository();
            Customer customer = repo.GetCutomerById(2);
            //Console.WriteLine(customer.CustomerName);
            //Console.WriteLine(customer.Address);

            customer.Address = "437/3, Senpara Parbata, Mirpur-10";

            //bool isSaved = repo.AddCutomer(customer);
            bool isSaved = repo.UpdateCutomer(customer);
            //bool isSaved = repo.DeleteCustomer(customer);
            if (isSaved)
            {
                Console.WriteLine("Saved!");
            }

            Console.ReadKey();
        }
    }
}
