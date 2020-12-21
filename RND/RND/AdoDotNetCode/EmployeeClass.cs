using RND.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RND.AdoDotNetCode
{
    public class EmployeeClass
    {
        public static List<Employee> GetAllEmployee()
        {
            List<Employee> list = new List<Employee>();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select * from dbo.Employee";

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = (int) reader["Id"];
                    employee.Name = (string) reader["Name"];
                    employee.Gender = (string) reader["Gender"];
                    employee.Salary = (int) reader["Salary"];
                    list.Add(employee);
                }
            }
            return list;
        }
    }
}