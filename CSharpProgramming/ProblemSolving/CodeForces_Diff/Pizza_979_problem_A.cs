using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces_Diff
{
    class Pizza_979_problem_A
    {
        public static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            if(x == 0)
            {
                Console.WriteLine(0);
            }
            else if((x+1) % 2 == 0)
            {
                Console.WriteLine((x+1)/2);
            }
            else
            {
                Console.WriteLine(x + 1);
            }
        }
    }
}
