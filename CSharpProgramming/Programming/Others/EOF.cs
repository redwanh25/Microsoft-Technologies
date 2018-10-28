using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Others
{
    class EOF
    {
        public static void Main(string[] args)
        {
            string str;
            while ((str = Console.ReadLine()) != null)      // ^z dile terminate korbe.
            {
                Console.WriteLine(int.Parse(str) - 1);
            }
        }
    }
}
