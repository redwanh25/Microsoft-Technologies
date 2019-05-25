using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using CIS.Lib.DALC;
using CIS.Lib.Utils;

namespace BFWS
{
    /// <summary>
    /// Summary description for OrcaWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrcaWebServices : System.Web.Services.WebService
    {


        /// <summary>
        /// This web service is created to get list of ORCA members that match the criteria
        /// </summary>
        /// <param name="strCriteria"></param>
        /// <param name="strOrderBy"></param>
        /// <returns>DataTable - Having List of ORCA Members Matched</returns>

        [WebMethod]
        public DataTable GetOrcaMembers(string strCriteria, string strOrderBy)
        {
            CIS.Lib.DALC.AppUser u = new CIS.Lib.DALC.AppUser();
            DataSet ds = u.FindOrcaMembers(strCriteria, strOrderBy);
            return ds.Tables[0];

        }
        /// <summary>
        /// This web service is for authenticate ORCA members
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>if matched, return True otherwise returns False</returns>

        [WebMethod]
        public bool AuthenticateOrcans(string userName, string password)
        {
            CIS.Lib.DALC.AppUser u = new CIS.Lib.DALC.AppUser();
            return u.AuthenticateOrcaMember(userName, password);
        }


        [WebMethod]
        public string HelloWorld(string strName, string strMessage)
        {
            string strResponse = "Hello my name is: " + strName + " and my message is: " + strMessage;

            return strResponse;

        }
    }
}
