using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Partial_Class
{
    class MainClass2
    {
        public static void Main(string[] args)
        {
            SamplePartialClass spc = new SamplePartialClass();
            spc.FirstName = "Ramijul";
            spc.LastName = "Islam";
            string fullName = spc.GetFullName();
            Console.WriteLine(fullName);

        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
