using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CIS.Lib.DALC;
using System.Web.Services;

namespace BFWS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BFServices : System.Web.Services.WebService
    {


        /// <summary>
        /// This method is used to get the list of orca members that match criteria 
        /// 
        /// </summary>
        /// <param name="strCriteria"></param>
        /// <param name="strColumn></param>
        /// <returns>DataTable having list of orca members</returns>

        [WebMethod]
        public DataTable GetOrcaMembers(string strCriteria, string strColumn)
        {
            CIS.Lib.DALC.AppUser u = new CIS.Lib.DALC.AppUser();
            DataSet ds = u.Find(string.Empty, string.Empty);
            return ds.Tables[0];

        }
    }
}
