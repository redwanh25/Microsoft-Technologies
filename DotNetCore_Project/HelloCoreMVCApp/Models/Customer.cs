using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Customer
    {
        public Customer()
        {
            //Orders = new List<Order>();
        }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        //public List<Order> Orders { get; set; }
    }
}
