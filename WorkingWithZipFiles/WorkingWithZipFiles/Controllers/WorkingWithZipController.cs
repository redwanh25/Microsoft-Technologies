using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkingWithZipFiles.DatabaseConnection;
using WorkingWithZipFiles.Models;

namespace WorkingWithZipFiles.Controllers
{
    public class WorkingWithZipController : Controller
    {
        
        private ZipFileStorAndDownloadEntities db = new ZipFileStorAndDownloadEntities();

        // GET: WorkingWithZip
        public ActionResult Index()
        {
            List<ZipFileStorAndDownload_tbl> list = db.ZipFileStorAndDownload_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase zip)
        {
            var filename = Server.MapPath("~/Uploads/" + zip.FileName);
            var file = Server.MapPath("~/Uploads/");
            if (System.IO.File.Exists(filename))
            {
                System.IO.File.Delete(filename);
            }
            zip.SaveAs(filename);
            // jekono file byte a convert kore dibe.
            byte[] bytes = System.IO.File.ReadAllBytes(filename);

            ConnectionWithDatabase connectionWithDatabase = new ConnectionWithDatabase();
            connectionWithDatabase.storeData(bytes, zip.FileName);
            System.IO.File.Delete(filename);

            // jekono file byte theke zip a convert kore dibe. shudhu zip na jodi extention
            // .png hoy .mp4 hoy .jpg hoy tao auto convert hoye jabe.
            //System.IO.File.WriteAllBytes(file+ "newFile.zip", bytes);

            Response.Redirect(Request.Url.ToString(), true);

            List<ZipFileStorAndDownload_tbl> list = db.ZipFileStorAndDownload_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            ConnectionWithDatabase connectionWithDatabase = new ConnectionWithDatabase();
            connectionWithDatabase.DeleteData(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public FileResult DownloadFile(int id)
        {
            ZipFileStorAndDownload_tbl fileById = db.ZipFileStorAndDownload_tbl.FirstOrDefault(per => per.Id == id);
            return File(fileById.ZipFile, "application/pdf", fileById.ZipFileName);
        }
    }
}