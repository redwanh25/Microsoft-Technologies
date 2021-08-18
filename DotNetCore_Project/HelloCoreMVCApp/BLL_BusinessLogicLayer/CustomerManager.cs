using BLL_BusinessLogicLayer.Base;
using DAL_DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer
{
    public class CustomerManager : Manager<Customer>
    {
        public CustomerManager() : base(new CustomerRepository())
        {
            
        }

        //public override Customer GetById<Y>(Y id)
        //{
        //    //Write Business Login Here

        //    Customer customer = _repository.GetById(id);
        //    return customer;
        //}

        public override bool Add(Customer customer)
        {
            //Write Business Login Here

            return _repository.Add(customer);
        }

        public override bool Update(Customer customer)
        {
            //Write Business Login Here

            return _repository.Update(customer);
        }
    }
}
