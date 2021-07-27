using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrystalReportsProject.Report
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public void LoadReport()
        {
            var reportParam = (dynamic) Session["ReportParam"];
            ReportDocument reportDocument = new ReportDocument();
            string path = Server.MapPath("~/CrystalReports/" + reportParam.RptFileName);
            var dataSource = reportParam.DataSoure;
            reportDocument.Load(path);
            reportDocument.SetDataSource(dataSource);
            reportDocument.SetParameterValue("@rptName", reportParam.ReportTitle);
            //reportDocument.SetParameterValue("My Parameter", "Redwan Hossain");
            reportDocument.SetParameterValue("SelectionRecord", 4000);
            
            reportDocument.DataDefinition.FormulaFields["ReportName"].Text = "{CrystalReportsProject_Models_Employee.Name}";
            CrystalReportViewer.ReportSource = reportDocument;

            //Response.Clear();
            //string filePath = Server.MapPath("~/Report/PDF_Reports/sample.pdf");
            //reportDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, filePath);
            //FileInfo fileInfo = new FileInfo(filePath);
            //Response.AddHeader("Content-Disposition", "inline;filename=sample.pdf");
            //Response.ContentType = "application/pdf";
            //Response.WriteFile(fileInfo.FullName);

            Stream stream = reportDocument.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);
            FileStream fileout = File.Create(Server.MapPath("~/Report/PDF_Reports/sample.pdf"));

            const int chunk = 512;
            byte[] buffer = new byte[512];
            int bytesread = stream.Read(buffer, 0, chunk);
            while (bytesread == chunk)
            {
                HttpContext.Current.Response.OutputStream.Write(buffer, 0, chunk);
                fileout.Write(buffer, 0, chunk);
                bytesread = stream.Read(buffer, 0, chunk);
            }

            HttpContext.Current.Response.OutputStream.Write(buffer, 0, bytesread);
            fileout.Write(buffer, 0, bytesread);
            fileout.Close();

            HttpContext.Current.Response.ContentType = "application/pdf";
        }
    }
}