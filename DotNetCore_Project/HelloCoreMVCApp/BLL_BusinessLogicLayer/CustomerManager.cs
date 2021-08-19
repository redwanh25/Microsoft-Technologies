using BLL_BusinessLogicLayer.Base;
using BLL_BusinessLogicLayer.Contracts;
using DAL_DataAccessLayer;
using DAL_DataAccessLayer.Contracts;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer
{
    public class CustomerManager : Manager<Customer>, ICustomerManager
    {
        private ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
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
