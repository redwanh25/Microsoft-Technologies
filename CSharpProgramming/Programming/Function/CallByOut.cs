using System;
using System.Collections;

namespace Programming.Function
{
    class CallByOut
    {
        public void Method(out String a)
        {
            a = "hossain";  // look at this line. ai line ta na dile error hobe.
            a += " eamil";
            Console.WriteLine("outside the main method : {0}", a);
        }
        public static void Main(String[] arg)
        {
            String str = "redwan";
            Console.WriteLine("inside the main method : {0}", str);
            CallByOut call = new CallByOut();
            call.Method(out str);         // out mane referance e jabe but, amder oi mehtod er moddhe age "a" k akta value diye assagine korte hobe.
            Console.WriteLine("inside the main method : {0}", str);

            Console.ReadKey();
        }
    }
}
