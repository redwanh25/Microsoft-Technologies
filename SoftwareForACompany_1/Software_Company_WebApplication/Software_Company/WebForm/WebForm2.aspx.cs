using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Software_Company.WebForm
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PopulateDataList();
            }
        }

        protected void OnClick(object sender, EventArgs e)
        {
            int repeatcolumn = Convert.ToInt32(hfColumnRepeat.Value);
            this.RsetepeatColumns(repeatcolumn);
        }

        private void PopulateDataList()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[6]{ new DataColumn("ContactName", typeof(string))
                                            ,new DataColumn("City", typeof(string))
                                            ,new DataColumn("PostalCode", typeof(string))
                                            ,new DataColumn("Country", typeof(string))
                                            ,new DataColumn("Phone", typeof(string))
                                            ,new DataColumn("Fax", typeof(string))
                                            });

            dt.Rows.Add("Mudassar Khan", "Warszawa", "01-012", "Belgium", "(26) 642-7012", "(26) 642-7012");
            dt.Rows.Add("Maria", "Boise", "12209", "Austria", "030-0074321", "030-0076545");
            dt.Rows.Add("Ana Trujillo", "México D.F.", "05021", "France", "(5) 555-4729", "5) 555-3745");
            dt.Rows.Add("Antonio Moreno", "Montréal", "05023", "Brazil", "(5) 555-3932", "");
            dt.Rows.Add("Thomas Hardy", "Mannheim", "WA1 1DP", "Ireland", "(171) 555-7788", "(171) 555-6750");
            dt.Rows.Add("Christina Berglund", "Luleå", "S-958 22", "Italy", "0921-12 34 65", "0921-12 34 67");
            dt.Rows.Add("Hanna Moos", "Mannheim", "68306", "Finland", "0621-08460", "0621-08924");
            dt.Rows.Add("Frédérique Citeaux", "Strasbourg", "67000", "Finland", "88.60.15.31", "88.60.15.32");
            dt.Rows.Add("Martín Sommer", "Madrid", "28023", "Argentina", "(91) 555 22 82", "(91) 555 91 99");

            dlCustomers.DataSource = dt;
            dlCustomers.DataBind();
        }

        private void RsetepeatColumns(int repeatcolumn = 5)
        {
            dlCustomers.RepeatColumns = repeatcolumn;
        }
    }
}