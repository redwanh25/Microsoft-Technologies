using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Product
    {
        public Product()
        {
            //Shops = new List<Shop>();
            //OrderDetails = new List<OrderDetail>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        //public List<Shop> Shops { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }

        public Category Category { get; set; }

        [NotMapped]
        public List<SelectListItem> CategoryItemList { get; set; }
    }
}
