using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class OverrideToStringMethod
    {
        public static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine(num);
            Console.WriteLine(num.ToString());

            Customer cus = new Customer();
            cus.FirstName = "Redwan";
            cus.LastName = "Hossain";
            Console.WriteLine(cus.ToString());
            Console.WriteLine(Convert.ToString(cus));
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
    
    //class Customer
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public override string ToString()
    //    {
    //        return base.ToString();
    //    }
    //}

    //class Customer
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}

}
