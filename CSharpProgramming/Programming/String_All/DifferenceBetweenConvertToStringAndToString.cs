using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class DifferenceBetweenConvertToStringAndToString
    {
        public static void Main()
        {
            Customer1 C1 = new Customer1();
            Console.WriteLine(Convert.ToString(C1));
            Console.WriteLine(C1.ToString());

            Customer1 C2 = null;
            Console.WriteLine(Convert.ToString(C2));
            //Console.WriteLine(C2.ToString());         // ai line a code ta crash korbe. cs, ToString() method
                                                        // null reference handel korte pare na. 
        }
    }
    public class Customer1
    {
        public string Name { get; set; }
    }
}
