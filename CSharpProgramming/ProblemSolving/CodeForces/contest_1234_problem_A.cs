using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces
{
    class contest_1234_problem_A
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[x];
                arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                double res = (double) arr.Sum() / x;
                double result = Math.Ceiling(res);
                Console.WriteLine("{0}", result);
            }
        }
    }
}
