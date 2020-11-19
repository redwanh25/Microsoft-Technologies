using CrystalReportsProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrystalReportsProject.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[Route("Employees/EmployeeReport")]
        public void EmployeeReport()
        {
            ReportParams<Employee> reportParams = new ReportParams<Employee>();
            reportParams.DataSoure = GetAllEmployee();
            reportParams.ReportTitle = "Employee Info Report";
            reportParams.RptFileName = "EmployeeInfoReport.rpt";
            Session["ReportType"] = "EmployeeInfoReport";
            Session["ReportParam"] = reportParams;

            Session["sSql"] = "select * from EmployeeView where DepartmentID = 1";
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> list = new List<Employee>();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select * from [dbo].[tblEmployee]";
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@value", value);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.ID = (int)reader["ID"];
                    employee.Name = (string)reader["Name"];
                    employee.Gender = (string)reader["Gender"];
                    employee.Salary = (int)reader["Salary"];
                    if(reader["DepartmentId"] != System.DBNull.Value)
                    {
                        employee.DepartmentId = (int)reader["DepartmentId"];
                    }
                    
                    list.Add(employee);
                }
                con.Close();
            }

            return list;
        }
    }
}