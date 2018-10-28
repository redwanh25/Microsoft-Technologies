using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jQuery_ASP_Bootstrap_Tutorial.ASP_Tutorial.ASP_1_To_10
{
    public partial class IsPostBack_Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCity();
            }

            // LoadCity();      // IsPostBack na diye check korle dropdownlist a item gula bar bar barte thakbe. 
        }

        private void LoadCity()
        {
            ListItem li1 = new ListItem("Bangladesh");
            DropDownList1.Items.Add(li1);
            ListItem li2 = new ListItem("London");
            DropDownList1.Items.Add(li2);
            ListItem li3 = new ListItem("Canada");
            DropDownList1.Items.Add(li3);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}