using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_All_Code_Web.LinqDemo
{
    public partial class LinqToSqlClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinqToSqlClass_DBDataContext dBDataContext = new LinqToSqlClass_DBDataContext();

            GridView1.DataSource = from person in dBDataContext.tblPersons
                                   select person;       // be careful select use korte e hobe. na hole error dibe.
            GridView1.DataBind();                       // lambda expression use korle select dite hoy na.

            GridView2.DataSource = from per in dBDataContext.tblPersons
                                   where per.Gender == "male"
                                   select per;
            GridView2.DataBind();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> even = from number in arr where number % 2 == 0 select number;
            Response.Write("Even Number : ");
            foreach (int it in even)
            {
                Response.Write(it + " ");
            }

            Response.Write("<br/>");

            // IEnumerator a foreach loop use kora jay na.
            IEnumerator<int> odd = arr.Where(num => num % 2 == 1).GetEnumerator();
            Response.Write("Odd Number : ");
            while (odd.MoveNext())
            {
                Response.Write(odd.Current + " ");
            }

            IEnumerable<Student> students = from stu in Student.GetAllStudents()
                                            where (stu.Gender == "Male")
                                            select stu;
            GridView3.DataSource = students;
            GridView3.DataBind();

            IEnumerable<Student> students1 = Student.GetAllStudents().Where(stu => stu.Gender == "Male");
            GridView4.DataSource = students1;
            GridView4.DataBind();
        }
    }
}