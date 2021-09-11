using Models;
using Models.DatabaseViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer.Contracts
{
    public interface ICustomerManager : IManager<Customer>
    {
        List<VMCustomer> GetCustomerListFromView();
    }
}
