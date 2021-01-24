using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace RDLC_Project.Controllers
{
    public class ReportController : Controller
    {

        public FileResult ReportGenerate()
        {
            ReportViewer rptViewer = new ReportViewer();

            //SqlConnection sqlConnection = new SqlConnection("");

            //string queryString1 = "";

            //SqlDataAdapter adapter = new SqlDataAdapter(queryString1, sqlConnection);
            //DataSet purchaseReturnMushak6_8 = new DataSet();
            //DataTable dt = new DataTable();
            //adapter.Fill(purchaseReturnMushak6_8, "SPResults");
            //dt = purchaseReturnMushak6_8.Tables[0];

            //rptViewer.LocalReport.DataSources.Add(new ReportDataSource("SPResults", dt));

            rptViewer.ProcessingMode = ProcessingMode.Local;
            rptViewer.Width = Unit.Percentage(100);
            rptViewer.LocalReport.EnableExternalImages = true;
            rptViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/Report-1.rdlc");

            rptViewer.LocalReport.Refresh();
            return File(GetPdf(rptViewer), "application/pdf");
        }

        private byte[] GetPdf(ReportViewer rpt) //FOR RDLC
        {
            Warning[] warnings;
            string[] streamIds;
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            return rpt.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);
        }
    }
}