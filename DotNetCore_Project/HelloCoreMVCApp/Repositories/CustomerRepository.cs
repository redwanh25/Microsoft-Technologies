using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class CustomerRepository
    {
        CustomerDbContext db = new CustomerDbContext();

        public Customer GetCutomerById(int id)
        {
            Customer customer = db.Customers.Find(id);
            return customer;
        }
        public List<Customer> GetAllCustomer()
        {
            return db.Customers.ToList();
        }

        public bool AddCutomer(Customer customer)
        {
            db.Entry(customer).State = EntityState.Added;
            return db.SaveChanges() > 0;
        }

        public bool UpdateCutomer(Customer customer)
        {
            db.Entry(customer).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool DeleteCustomer(Customer customer)
        {
            db.Entry(customer).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
        
    }
}
