using SignalR_SqlDependency.Hubs;
using SignalR_SqlDependency.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR_SqlDependency.Controllers
{
    public class CustomerController : Controller
    {
        MVC_DatabaseEntities db = new MVC_DatabaseEntities();

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        // Without Entity Framework
        public ActionResult Get()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = @"SELECT [Id],[CustomerName],[Status] FROM [dbo].[CustomerInfo]";     // WHERE [Status] <> 0
                    cmd.Notification = null;

                    SqlDependency dependency = new SqlDependency(cmd);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    var listCus = reader.Cast<IDataRecord>()
                            .Select(x => new
                            {
                                Id = (int)x["Id"],
                                CustomerName = (string)x["CustomerName"],
                                Status = (bool)x["Status"],
                            }).ToList();

                    return Json(new { listCus = listCus }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        // Using Entity Framework
        public ActionResult Get_1()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = @"SELECT [Id],[CustomerName],[Status] FROM [dbo].[CustomerInfo] WHERE [Status] <> 0";
                    // query er  upor depend korbe OnChangeEventHandler execute hobe ki na. cs, jodi ami
                    // @"SELECT [Id] FROM [dbo].[CustomerInfo]" ai query kore [CustomerName] update kori taile
                    // OnChangeEventHandler execute hobe na. cs, ami query te select er pore [CustomerName] deini.
                    // jodi ami @"SELECT [Id], [CustomerName] FROM [dbo].[CustomerInfo]" ai query kore [CustomerName] update kori
                    // taile OnChangeEventHandler execute hobe. but, [Status] update kori taile OnChangeEventHandler execute hobe na.
                    // cs, ami query te select er pore [Status] deini.

                    cmd.Notification = null;

                    SqlDependency dependency = new SqlDependency(cmd);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<CustomerInfo> customerList = db.CustomerInfoes.ToList();   // .Where(x => x.Status == true)

                    return Json(new { listCus = customerList }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            CustomerHub.Show();

            //if(e.Type == SqlNotificationType.Change)
            //{
            //    CustomerHub.Show();
            //}
        }
    }
}