using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Partial_Class
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
