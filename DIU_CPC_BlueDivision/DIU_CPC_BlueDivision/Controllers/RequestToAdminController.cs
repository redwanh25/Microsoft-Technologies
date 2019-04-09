using DIU_CPC_BlueDivision.DatabaseConnection;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class RequestToAdminController : Controller
    {
        // GET: RequestToAdmin
        [Route("Controllers/RequestToAdmin/RequestToAdminForUnmute")]
        public void RequestToAdminForUnmute()
        {
            string U_id = "";
            U_id = User.Identity.GetUserId();
            ListOfAllAdminsAndStudents listOfStudents = new ListOfAllAdminsAndStudents();
            listOfStudents.UpdateStudentsRequest(U_id);

        }
    }
}