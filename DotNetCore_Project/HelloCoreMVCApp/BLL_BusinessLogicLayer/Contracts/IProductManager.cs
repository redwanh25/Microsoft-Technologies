﻿using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_BusinessLogicLayer.Contracts
{
    public interface IProductManager : IManager<Product>
    {
        List<Product> GetByYear(int year);
    }
}