using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrystalReportsProject.Report
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public void LoadReport()
        {
            ReportDocument reportDocument = new ReportDocument();

            string queryString1 = Session["sSql"].ToString();
            string reportPath = Server.MapPath("~/CrystalReports/CrystalReport1.rpt");
            reportDocument.Load(reportPath);
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(queryString1, sqlConnection);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                adapter.Fill(ds, "EmployeeView");
                dt = ds.Tables["EmployeeView"];   // // ds.Tables[0]
                int departmentID = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    departmentID = (int) dr["DepartmentID"];
                }


                DataSet ds1 = new DataSet();
                string queryString2 = "SELECT * FROM tblDepartment WHERE ID = 1";
                SqlDataAdapter adapter1 = new SqlDataAdapter(queryString2, sqlConnection);
                adapter1.Fill(ds1, "tblDepartment"); 


                reportDocument.SetDataSource(ds.Tables["EmployeeView"]);
                reportDocument.Subreports["CrystalSubReport1"].SetDataSource(ds1.Tables["tblDepartment"]);   // Subreports[0] // ds1.Tables[0]

                //reportDocument.SetDatabaseLogon("sa", "manager", sqlConnection.DataSource, sqlConnection.Database);
                //reportDocument.Subreports[0].SetDatabaseLogon("sa", "manager", sqlConnection.DataSource, sqlConnection.Database);

                //reportDocument.SetParameterValue("MyParameter", "Hello World");
                //reportDocument.SetParameterValue("MyParameterSub", "Hello World Sub", reportDocument.Subreports[0].Name.ToString());
                //reportDocument.SetParameterValue("MyParameterSub", "Hello World Sub", "CrystalSubReport1");

                reportDocument.DataDefinition.FormulaFields["ReportName"].Text = "{EmployeeView.Gender}";
                reportDocument.Subreports[0].DataDefinition.FormulaFields["ReportNameSub"].Text = "{tblDepartment.Location}";
                
                CrystalReportViewer1.ReportSource = reportDocument;
                CrystalReportViewer1.DataBind();
                CrystalReportViewer1.RefreshReport();
            }
        }
    }
}