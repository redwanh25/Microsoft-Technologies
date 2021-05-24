using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainstation
{
    class Problem_B
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int i, c0 = 0, c5 = 0;
            for (i = 0; i < n; i++)
            {
                if (a[i] == 0)
                {
                    c0++;
                }
                else
                {
                    c5++;
                }
            }
            c5 = (c5 / 9) * 9;
            if (c0 == 0)
            {
                Console.WriteLine(-1);
            }

            else if (c5 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (i = 0; i < c5; i++)
                {
                    Console.Write(5);
                }
                for (i = 0; i < c0; i++)
                {
                    Console.Write(0);
                }
            }
            //Console.ReadKey();
        }
    }
}
