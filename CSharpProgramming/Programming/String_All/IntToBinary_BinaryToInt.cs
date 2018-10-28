using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class IntToBinary_BinaryToInt
    {
        public static void Main(String[] args)
        {
            int value = 8;
            String binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);

            String str = "1111";
            int ans = Convert.ToInt32(str, 2);
            Console.WriteLine(ans);

        }
    }
}
