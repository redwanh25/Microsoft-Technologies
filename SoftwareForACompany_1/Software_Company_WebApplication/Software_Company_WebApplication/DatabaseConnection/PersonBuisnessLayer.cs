using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace Software_Company_WebApplication.DatabaseConnection
{
    public class PersonBuisnessLayer
    {
        public IEnumerable<PersonMessage> personsIndex
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                List<PersonMessage> per = new List<PersonMessage>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "tblPersonProc";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        PersonMessage person = new PersonMessage();
                        person.Id = Convert.ToInt32(rdr["Id"]);

                        string name = Convert.ToString(rdr["Name"]);
                        if (name.Length >= 14)
                        {
                            StringBuilder sb = new StringBuilder(name);
                            sb.Remove(14, sb.Length - 14);
                            name = sb.ToString() + "...";

                        }
                        person.Name = name;

                        string phoneNumber = Convert.ToString(rdr["Phone Number"]);
                        if (phoneNumber.Length >= 14)
                        {
                            StringBuilder sb = new StringBuilder(phoneNumber);
                            sb.Remove(14, sb.Length - 14);
                            phoneNumber = sb.ToString() + "...";

                        }
                        person.PhoneNumber = phoneNumber;

                        string email = Convert.ToString(rdr["Email"]);
                        if (email.Length >= 14)
                        {
                            StringBuilder sb = new StringBuilder(email);
                            sb.Remove(14, sb.Length - 14);
                            email = sb.ToString() + "...";

                        }
                        person.Email = email;

                        string address = Convert.ToString(rdr["Address"]);
                        if (address.Length >= 14)
                        {
                            StringBuilder sb = new StringBuilder(address);
                            sb.Remove(14, sb.Length - 14);
                            address = sb.ToString() + "...";

                        }
                        person.Address = address;

                        person.Date = Convert.ToDateTime(rdr["Date"]);

                        string message = Convert.ToString(rdr["Message"]);
                        if (message.Length >= 40)
                        {
                            StringBuilder sb = new StringBuilder(message);
                            sb.Remove(40, sb.Length - 40);
                            message = sb.ToString() + "...";
                        }
                        person.Message = message;
                        per.Add(person);
                    }
                }
                return per;
            }
        }
        public IEnumerable<PersonMessage> personsDetails
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                List<PersonMessage> per = new List<PersonMessage>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "tblPersonProc";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        PersonMessage person = new PersonMessage();
                        person.Id = Convert.ToInt32(rdr["Id"]);
                        person.Name = Convert.ToString(rdr["Name"]);
                        person.PhoneNumber = Convert.ToString(rdr["Phone Number"]);
                        person.Email = Convert.ToString(rdr["Email"]);
                        person.Address = Convert.ToString(rdr["Address"]);
                        person.Date = Convert.ToDateTime(rdr["Date"]);
                        person.Message = Convert.ToString(rdr["Message"]);
                        per.Add(person);
                    }
                }
                return per;
            }
        }
        public void DeleteEmployee(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete from PersonMessage_tbl where id = @parameter";
                cmd.Parameters.AddWithValue("@parameter", id);
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}