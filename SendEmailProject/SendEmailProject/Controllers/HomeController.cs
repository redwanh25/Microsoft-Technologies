using SendEmailProject.Essential;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SendEmailProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        
        [HttpPost]
        public void Template(string value)
        {
            SendEmailClass emailClass = new SendEmailClass();
            emailClass.SendMail(value, "redwanh25@gmail.com");
        }
    }
}