using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Count
    {
        public static void Main(string[] args)
        {
            int i = 0;
            string str;
            while ((str = Console.ReadLine()) != null)
            {
                i++;
            }
            Console.WriteLine(i);

        }
    }
}
