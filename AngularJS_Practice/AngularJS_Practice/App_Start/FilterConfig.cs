﻿using System.Web;
using System.Web.Mvc;

namespace AngularJS_Practice
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
