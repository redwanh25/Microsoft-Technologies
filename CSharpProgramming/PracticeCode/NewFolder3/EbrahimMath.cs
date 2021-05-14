using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.NewFolder3
{
    class EbrahimMath
    {
        public static void Main()
        {
            int val = int.Parse(Console.ReadLine());
            int x = (val - 2) / 2;
            int y = x + 2;
            Console.WriteLine("X     = {0}\nX + 2 = {1}", x, y);
            //Console.WriteLine("X = {0}\nY = {1}", x, y);
            Console.ReadKey();
        }
    }
}
