using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using QRCodeGenerator_AudioVideoImage.DatabaseConnection;
using QRCodeGenerator_AudioVideoImage.Models;
using QRCoder;

namespace QRCodeGenerator_AudioVideoImage.Controllers
{
    public class QRCodeStringController : Controller
    {
        private QRCodeStringEntities db = new QRCodeStringEntities();

        // GET: QRCodeString
        public ActionResult Index()
        {
            List<QRCodeString_tbl> list = db.QRCodeString_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }

        [HttpPost]
        public ActionResult Index(string qrcode)
        {
            byte[] image;
            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData data = qrGenerator.CreateQrCode(qrcode, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                using (Bitmap bitMap = code.GetGraphic(20))
                {
                    bitMap.Save(ms, ImageFormat.Png);
                    image = ms.GetBuffer();     // convert image to byte formate 
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }

            }

            QRCodeString qRCodeString = new QRCodeString();
            qRCodeString.storeData(image, qrcode);

            //Response.Redirect(Request.Url.ToString(), true);

            List<QRCodeString_tbl> list = db.QRCodeString_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            QRCodeString qrCodeString = new QRCodeString();
            qrCodeString.DeleteData(id);
            return RedirectToAction("Index");
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
