using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Control_Statement
{
    class SwitchCase
    {
        public static void Main(String[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("redwan");
                    break;

                case 2:
                    Console.WriteLine("Hossain");
                    break;

                default :
                    Console.WriteLine("None");
                    break;
            }
            Console.ReadKey();
        }
    }
}

