using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Software_Company_WebApplication.DatabaseConnection
{
    public class BlogDivIdClass
    {
        public int BlogDivIdValue()
        {
            int id = 0;
            string cs = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select top 1 id from Blog_tbl order by id desc", con);
                con.Open();
                // table jodi faka thake taile kintu ExecuteScalar a exception throw korbe karon
                // top value to nai. she kmne retrive korbe. oi jonno return 1 diye first time value
                // nije theke value ta set kore dite hobe. taile r problem hobe na. 
                id = (int)cmd.ExecuteScalar();
            }
            return (id+1);
        }
    }
}