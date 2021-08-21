using AutoMapper;
using HelloCoreMVCApp.Models.ProductViewModel;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMVCApp.AutoMapperConfig
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<Source, Destination>();

            CreateMap<ProductCreateVM, Product>();
            CreateMap<Product, ProductListVM>();
        }
    }
}
