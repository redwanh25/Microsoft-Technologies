using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }
        public double UnitPrice { get; set; }
        public int DiscountPercentage { get; set; }
    }
}
