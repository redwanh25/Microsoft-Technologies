using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for DataAccess
/// </summary>
/// 
 public class Employees
    {
     public string UserName{get;set;} 
     public string ChildcommentMessage{get;set;}
     public string ChilCommentDate { get; set; }
    }
public class DataAccess
{
    public static List<Employees> GetAllemployees(int ParebCommentID)
    {
        List<Employees> listEmployee = new List<Employees>();
        string cs = ConfigurationManager.ConnectionStrings["commentConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("select ChildComment.UserName,ChildComment.CommentMessage,ChildComment.CommentDate from ChildComment where ParebCommentID=@ParebCommentID", con);
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@ParebCommentID";
            parameter.Value = ParebCommentID;
            cmd.Parameters.Add(parameter);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employees employee = new Employees();
                employee.UserName = rdr["UserName"].ToString();
                string date = rdr["CommentDate"].ToString();
                date = date.Substring(0, date.LastIndexOf("/") + 5);
                employee.ChilCommentDate = date;
                employee.ChildcommentMessage = rdr["CommentMessage"].ToString();
                listEmployee.Add(employee);
            }


        }
        return listEmployee;
    }
	 
}
 