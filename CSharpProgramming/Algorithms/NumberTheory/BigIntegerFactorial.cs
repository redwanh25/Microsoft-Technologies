using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;      // aita referance e giye add korte hobe. automatic thake na. er moddhe BigInteger ase.

namespace Algorithms.NumberTheory
{
    class BigIntegerFactorial
    {
        public static void Main(string[] str)
        {
            BigInteger res = fact(1000);
            Console.WriteLine(res);
        }
        public static BigInteger fact(int f)
        {
            BigInteger x = 1;
            for(int i = 2; i <= f; i++)
            {
                x *= i;
            }
            return x;
        }
    }
}
