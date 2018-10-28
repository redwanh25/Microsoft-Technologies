using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NumberTheory
{
    class TrailingZeroesOfFactorial
    {
        public static void Main(string[] args)
        {
            string str;
            while((str = Console.ReadLine()) != null){
                int n = int.Parse(str);
                double result = 0, x = 5, i = 1;
                while (x <= n)
                {
                    result += Math.Floor(n / x);
                    x = Math.Pow(5, ++i);
                }
                Console.WriteLine("{0}! = {1} Trailing Zeroes", n, result);
            }
        }
    }
}
