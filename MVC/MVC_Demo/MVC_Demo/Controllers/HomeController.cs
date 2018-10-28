using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public string Details(string id, string name, string sec)
        {
            //http://localhost:53953/home/details?id=10&name=redwan&sec=D or
            //http://localhost:53953/home/details/?id=10&name=redwan&sec=D or
            //http://localhost:53953/home/details/10?name=redwan&sec=D
            // ? means parameter dibo.
            string str = "Id: " + id + "</br>Name: " + name + "</br>Sec: " + sec;
            //string str = "Id: " + id + "</br>Name: " + Request.QueryString["name"] + "</br>Sec: " + sec;
            // Request.QueryString te []er vitore "red" dile hobe na. but, hobe. tokohon amader
            //http://localhost:53953/home/details?id=10&red=redwan&sec=D use korte hobe. mane red tai final. parameter er name ta kono kisu na.
            return str;
        }

        public ActionResult Country()
        {
            ViewBag.countryName = new List<string>()
            {
                "India",
                "Bangladesh",
                "Canada"
            };
            ViewData["countryName"] = new List<string>()
            {
                "Amr",
                "Shonar",
                "Bangla"
            };
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}