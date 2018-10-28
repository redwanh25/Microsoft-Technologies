using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces
{
    class Phone_numbers
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                int s = int.Parse(Console.ReadLine());
                if(s == 0) { break; }
                string[] str = new string[s];
                int len = 0;
                for (int i = 0; i < s; i++)
                {
                    str[i] = Console.ReadLine();
                    len = Math.Max(len, str[i].Length);
                }
                for (int i = 0; i < s; i++)
                {
                    Console.WriteLine(str[i].PadLeft(len, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
