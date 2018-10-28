using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class Split_S
    {
        public static void Main(string[] args)
        {
            string s1 = "Helo lfsf lfslf   C#";
            string[] s2 = s1.Split('l');
            foreach(var it in s2)
            {
                Console.WriteLine(it);
            }
        }
    }
}
