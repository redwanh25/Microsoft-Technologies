using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class EndsWith_E
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "llo";
            string s3 = "ll";
            Console.WriteLine(s1.EndsWith(s2));
            Console.WriteLine(s1.EndsWith(s3));
        }
    }
}
