using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_API
{
    public partial class TestingWebServices_API : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateGridView();
            }
        }

        protected void Search(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            string apiUrl = "http://localhost:49910/api/members/";
            object input = new
            {
                FirstName = FirstNameTextBox.Text.Trim(),

            };
            string inputJson = (new JavaScriptSerializer()).Serialize(input);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl + "/GetMembers", inputJson);

            GridView1.DataSource = (new JavaScriptSerializer()).Deserialize<List<Members>>(json);
            GridView1.DataBind();
        }

        public class Members
        {
            public int MemberID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Nullable<int> BatchID { get; set; }
            public string CadetNo { get; set; }
            public string HomeEmail { get; set; }
            public string HomePhone { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string CountryID { get; set; }
        }
    }
}

//LastName = LastNameTextBox.Text.Trim(),
//BatchID = BatchIDTextBox.Text.Trim(),
//CadetNo = CadetNoTextBox.Text.Trim(),
//HomeEmail = HomeEmailTextBox.Text.Trim(),
//City = CityTextBox.Text.Trim(),
//State = StateTextBox.Text.Trim(),
//CountryID = CountryIDTextBox.Text.Trim(),