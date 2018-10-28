using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Function
{
    class CallByValue
    {
        public void Method(int a)
        {
            a *= a;
            Console.WriteLine("outside the main method {0}", a);
        }

        public static void Main(String[] arg)
        {
            int a = 50;
            Console.WriteLine("inside the main method {0}", a);
            CallByValue call = new CallByValue();
            call.Method(a);
            Console.WriteLine("inside the main method {0}", a);

            Console.ReadKey();
        }
    }
}
