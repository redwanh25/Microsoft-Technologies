using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using DAL_DataAccessLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_DataAccessLayer.Contracts;
using Models.DatabaseViewModel;

namespace DAL_DataAccessLayer
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public override Customer GetById<Y>(Y id)
        {
            Customer customer = db.Customers.Find(id);
            return customer;
        }
        public override bool Add(Customer customer)
        {
            db.Entry(customer).State = EntityState.Added;
            return db.SaveChanges() > 0;
        }

        public List<VMCustomer> GetCustomerListFromView()
        {
            return db.VMCustomers.ToList();
        }
    }
}
