using ImportExcelDataToMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excel = Microsoft.Office.Interop.Excel;

namespace ImportExcelDataToMVC.Controllers
{
    public class ImportExcelDataController : Controller
    {
        Problems_DBEntities db = new Problems_DBEntities();

        // GET: ImportExcelData
        [HttpGet]
        public ActionResult Import()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Import(HttpPostedFileBase excelfile)
        {

            if (excelfile == null || excelfile.ContentLength == 0)
            {
                ViewBag.Error = "Please Select a excel file <br>";
                return View();
            }
            else
            {
                if (excelfile.FileName.EndsWith("xls") || excelfile.FileName.EndsWith("xlsx"))
                {
                    string path = Server.MapPath("~/Files/" + excelfile.FileName);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    excelfile.SaveAs(path);

                    // read data from excel file

                    Excel.Application application = new Excel.Application();
                    Excel.Workbook workbook = application.Workbooks.Open(path);
                    Excel.Worksheet worksheet = workbook.ActiveSheet;
                    Excel.Range range = worksheet.UsedRange;

                    for (int row = 2; row <= range.Rows.Count; row++)
                    {
                        Problem problem = new Problem();
                        problem.ProblemName = ((Excel.Range)range.Cells[row, 1]).Text;
                        problem.ProblemLink = ((Excel.Range)range.Cells[row, 2]).Text;
                        db.Problems.Add(problem);
                    }
                    db.SaveChanges();
                    application.Workbooks.Close();

                    return View();
                }
                else
                {
                    ViewBag.Error = "File type is incorrect <br>";
                    return View();
                }
            }

        }

        public string UniqueIdGenerate()
        {
            byte[] buffer1 = Guid.NewGuid().ToByteArray();
            string number = BitConverter.ToUInt32(buffer1, 8).ToString();
            number += String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            byte[] buffer2 = Guid.NewGuid().ToByteArray();
            number += BitConverter.ToUInt32(buffer2, 8).ToString();
            return number;
        }
    }
}