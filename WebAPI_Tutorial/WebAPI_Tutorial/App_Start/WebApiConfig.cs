using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI_Tutorial
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // remove xml formate. akhun shudhu json formate e show korbe.
            // config.Formatters.Remove(config.Formatters.XmlFormatter);

            // remove json formate. akhun shudhu xml formate e show korbe. but, ai ta dile nicher camel case er oi dui line er code
            // kora jabe na.
            // config.Formatters.Remove(config.Formatters.JsonFormatter);

            // Camel Case formate instade of pascal case
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // for crose domain
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            //config.Filters.Add(new RequireHttpsAttribute());
            //config.Filters.Add(new BasicAuthenticationAttribute());

        }
    }
}
