using Models;
using Models.DatabaseViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_DataAccessLayer.Contracts
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        List<VMCustomer> GetCustomerListFromView();
    }
}
