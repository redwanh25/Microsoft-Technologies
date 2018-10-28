using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Others
{
    class ParseAndTryParse
    {
        public static void Main()
        {
            //  string str = "123GH";     int.Parse(str); te exception throw korbe.
            string str = "123"; 
            int res;
            bool ck = int.TryParse(str, out res);
            Console.WriteLine("{0}", ck ? res.ToString() : "enter a valid number");
            int i = int.Parse(str);     
            Console.WriteLine(i);
        }
    }
}

