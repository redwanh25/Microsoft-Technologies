using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusinessLayer
{
    public class EmployeeBuisnessLayer
    {
        public IEnumerable<Employee> employees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                List<Employee> emps = new List<Employee>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "tblEmployeeProc";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = Convert.ToInt32(rdr["Id"]);
                        employee.Name = Convert.ToString(rdr["Name"]);
                        employee.Gender = Convert.ToString(rdr["Gender"]);
                        employee.City = Convert.ToString(rdr["City"]);
                        employee.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                        emps.Add(employee);
                    }
                }
                return emps;
            }
        }

        private void attachParameters(SqlCommand cmd, string parameter, object val)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = parameter;
            if(val is DateTime)
            {
                sqlParameter.Value = Convert.ToDateTime(val);
            }
            else if(val is int)
            {
                sqlParameter.Value = Convert.ToInt32(val);
            }
            else
            {
                sqlParameter.Value = val.ToString();
            }
            
            cmd.Parameters.Add(sqlParameter);
        }

        public void AddEmployee (Employee employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                attachParameters(cmd, "@Name",  employee.Name);
                attachParameters(cmd, "@Gender", employee.Gender);
                attachParameters(cmd, "@City", employee.City);
                attachParameters(cmd, "@DateOfBirth", employee.DateOfBirth);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveEmployee(Employee employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                attachParameters(cmd, "@Id", employee.Id);
                attachParameters(cmd, "@Name", employee.Name);
                attachParameters(cmd, "@Gender", employee.Gender);
                attachParameters(cmd, "@City", employee.City);
                attachParameters(cmd, "@DateOfBirth", employee.DateOfBirth);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete from tblEmployee where id = @parameter";
                cmd.Parameters.AddWithValue("@parameter", id);
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        } 
    }
}
