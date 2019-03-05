using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Software_Company_Website.Models;

namespace Software_Company_Website.Controllers
{
    public class GalleryController : Controller
    {
        private GalleryDBEntities db = new GalleryDBEntities();

        // GET: Gallery
        //public ActionResult Index()
        //{
        //    List<Gallery_tbl> list = db.Gallery_tbl.ToList();
        //    list = list.OrderByDescending(it => it.Id).ToList();
            
        //    return View(list);
        //}

        public static string hrefLink(int Id, byte[] cImgSrc)
        {
            string str = String.Format("~/GalleryImage/Hello{0}.jpg", Id);
            string str1 = String.Format("../GalleryImage/Hello{0}.jpg", Id);
            Base64ToImage(Convert.ToBase64String((byte[])cImgSrc)).Save(System.Web.HttpContext.Current.Server.MapPath(str));
            return str1;
        }

        //byte code to image
        public static System.Drawing.Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
