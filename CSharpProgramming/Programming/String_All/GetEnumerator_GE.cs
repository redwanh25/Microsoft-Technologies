using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class GetEnumerator_GE
    {
        public static void Main(string[] args)
        {
            string s2 = "Hello C#";
        //    IEnumerator ch = s2.GetEnumerator();      // same output ashbe
            CharEnumerator ch = s2.GetEnumerator();
            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
            }
        }
    }
}
