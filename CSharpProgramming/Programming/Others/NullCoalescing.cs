using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Others
{
    class NullCoalescing
    {
        public static void Main()
        {
            //   int i = null;     // error hobe.   int er pore akta ? sign dite hobe.
            int? i = null;
            bool? ck = null;
            string str = null;
            Console.WriteLine(i + " " + ck + " " + str);

            i = 100;
            Console.WriteLine(i);

            int assagin; 
            if (i == null)
            {
                assagin = 0;
            }
            else
            {
                assagin = (int) i;
            }
            Console.WriteLine(assagin);

            // uporer kaj ta ak line a kora jay.
            assagin = i ?? 0;
            Console.WriteLine(assagin);
        }
    }
}
