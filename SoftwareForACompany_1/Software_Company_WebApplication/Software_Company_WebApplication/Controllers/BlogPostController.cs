using Software_Company_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Software_Company_WebApplication.Controllers
{
    public class BlogPostController : Controller
    {
        // GET: BlogPost
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Blog_Post()
        {
            Blog_tbl b1 = new Blog_tbl();
            return View(b1);
        }
        [HttpPost]
        public ActionResult Blog_Post(Blog_tbl model, HttpPostedFileBase image1) // ai image1 nam ta idr nam er same hote hobe.
        {
            Software_CompanyDBEntities1 db = new Software_CompanyDBEntities1();
            if (image1 != null)
            {
                model.BlogImage = new byte[image1.ContentLength];
                image1.InputStream.Read(model.BlogImage, 0, image1.ContentLength);
            }
            model.Date = DateTime.Now;
            db.Blog_tbl.Add(model);
            db.SaveChanges();
            string url = Request.Url.AbsoluteUri;
            Response.Redirect(url);
            return View(model);
        }
    }
}