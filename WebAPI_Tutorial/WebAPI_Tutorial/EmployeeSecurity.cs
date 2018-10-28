using EmployeeDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Tutorial
{
    public class EmployeeSecurity
    {
        public static bool login(string username, string password)
        {
            using(WebAPI_Tutorial_DatabaseEntities entity = new WebAPI_Tutorial_DatabaseEntities())
            {
                return entity.Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password.Equals(password));
            }
        }
    }
}