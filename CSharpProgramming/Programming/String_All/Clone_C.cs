using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class Clone_C
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello ";
            string s2 = (String)s1.Clone();
            s2 += "world";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            String s3 = s1;
            s3 += "redwan";

            Console.WriteLine(string.Compare(s3, s1));

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
