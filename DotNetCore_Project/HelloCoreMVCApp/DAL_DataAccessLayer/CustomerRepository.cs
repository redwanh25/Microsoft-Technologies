using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using DAL_DataAccessLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL_DataAccessLayer
{
    public class CustomerRepository : Repository<Customer>
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
    }
}
