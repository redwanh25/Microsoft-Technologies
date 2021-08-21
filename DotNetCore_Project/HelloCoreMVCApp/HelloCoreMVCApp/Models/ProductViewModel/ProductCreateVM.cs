using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMVCApp.Models.ProductViewModel
{
    public class ProductCreateVM
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public List<SelectListItem> CategoryItemList { get; set; }
    }
}
