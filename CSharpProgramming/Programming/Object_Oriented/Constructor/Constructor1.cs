using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Constructor
{
    class Constructor1
    {
        private int a;
        private int b;
        public Constructor1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static void Main(String[] str)
        {
            Constructor1 cons = new Constructor1(1, 2);
            Console.WriteLine(cons.a);
            Console.WriteLine(cons.b);
            Console.ReadKey();
        }
    }
}
