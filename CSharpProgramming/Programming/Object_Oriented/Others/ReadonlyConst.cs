using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Others
{
    class ReadonlyConst
    {
        private readonly int a = 1;
        private readonly int b;
        private const int c = 5;

        public ReadonlyConst()
        {
            b = 2;      
            a = 3;
            a = 4;
            a += c;     // readonly te value assign kora jay (constructor er bahire assign kora jabe na).
         // c = 121;    // const a ta kora jabe na
        }

        public static void Main(String[] str)
        {
            ReadonlyConst cons = new ReadonlyConst();

            Console.WriteLine(cons.a);
            Console.WriteLine(cons.b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
