using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Software_Company_Website
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Mvc routes
            routes.MapMvcAttributeRoutes();     // if we comment this line route will not work.
            // look at /Controllers/MainPageBlog_tbl/ContactPopUp

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MainPageBlog_tbl", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
