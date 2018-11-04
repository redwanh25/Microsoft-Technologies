using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Partial_Class
{
    class MainClass1
    {
        public static void Main(string[] args)
        {
            Customer1 cus = new Customer1();
            cus.FirstName = "Redwan";
            cus.LastName = "Hossain";
            string fullName1 = cus.GetFullName();
            Console.WriteLine(fullName1);

            PartialCustomer pc = new PartialCustomer();
            cus.FirstName = "Shihab";
            cus.LastName = "Khan";
            string fullName2 = cus.GetFullName();
            Console.WriteLine(fullName2);
        }
        
    }
}
