using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class _10_EvenOrOdd
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x % 2 == 0 && x < 0)
                    Console.Write("EVEN NEGATIVE\n");
                if (x % 2 == 0 && x > 0)
                    Console.Write("EVEN POSITIVE\n");
                if (x % 2 != 0 && x < 0)
                    Console.Write("ODD NEGATIVE\n");
                if (x % 2 != 0 && x > 0)
                    Console.Write("ODD POSITIVE\n");
                if (x == 0)
                    Console.Write("NULL\n");
            }
        }
    }
}
