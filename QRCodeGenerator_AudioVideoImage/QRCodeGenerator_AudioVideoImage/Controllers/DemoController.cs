using QRCodeGenerator_AudioVideoImage.DatabaseConnection;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZXing;

namespace QRCodeGenerator_AudioVideoImage.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
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
            //QRCodeString qRCodeString = new QRCodeString();
            //qRCodeString.storeData(image, qrcode);

            return View();
        }
    }
}