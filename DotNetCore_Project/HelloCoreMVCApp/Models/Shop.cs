using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Shop
    {
        public Shop()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Product> Products { get; set; }
    }
}
