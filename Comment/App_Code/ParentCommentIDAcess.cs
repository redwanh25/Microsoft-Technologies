using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ParentCommentIDAcess
/// </summary>
/// 
public class ParentComment
{
    public int ParentCommentID { get; set; }
    public string ParanetCommentDate { get; set; }
    public string ParentCommentMessage { get; set; }
    public string ParentUserName { get; set; }
    public List<Employees> Empl
    {
        get {
            return DataAccess.GetAllemployees(this.ParentCommentID);
        }
    }
 
     
}
public class ParentCommentIDAcess
{
	 
		public static List<ParentComment> GetAllDepartmentsandEmployee()
        {
            List<ParentComment> listDepartments = new List<ParentComment>();
            string cs = ConfigurationManager.ConnectionStrings["commentConnectionString"].ConnectionString;
 using (SqlConnection con = new SqlConnection(cs))
 {
     SqlCommand cmd = new SqlCommand("Select *from ParentComment", con);
     con.Open();  
     SqlDataReader rdr = cmd.ExecuteReader();
     while(rdr.Read())

     {
         ParentComment parent = new ParentComment();
         parent.ParentCommentID = Convert.ToInt32(rdr["CommentID"]);
         parent.ParentUserName = rdr["UserName"].ToString();
         string date = rdr["CommentDate"].ToString();
         date = date.Substring(0,date.LastIndexOf("/") + 5);
         parent.ParanetCommentDate = date;
         parent.ParentCommentMessage = rdr["CommentMessage"].ToString();
         listDepartments.Add(parent);
     }
 }
 return listDepartments;
        }
 
	}
 