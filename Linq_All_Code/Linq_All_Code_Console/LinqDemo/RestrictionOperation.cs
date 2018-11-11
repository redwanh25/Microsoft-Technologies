using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    class RestrictionOperation
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //=========================

            IEnumerable<int> even = arr.Where(a => a % 2 == 0);
            foreach(int i in even)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //=========================

            Func<int, bool> predicate = a => a % 2 == 0;
            IEnumerable<int> even1 = arr.Where(predicate);
            foreach (int i in even1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //=========================

            IEnumerable<int> even2 = arr.Where(x => isEven(x));
            foreach (int i in even2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //=========================

            var even3 = arr.Select((number, index) => new { Number = number, Index = index });
            foreach (var item in even3)
            {
                Console.WriteLine(item.Number + " -- " + item.Index);
            }
            Console.WriteLine();

            //=========================

            var even4 = arr.Select((number, index) => new { Number = number, Index = index })
                .Where(x => x.Number % 2 == 0);
            foreach (var item in even4)
            {
                Console.WriteLine(item.Number + " -- " + item.Index);
            }
            Console.WriteLine();

            //=========================

            IEnumerable<int> even5 = arr.Select((number, index) => new { Number = number, Index = index })
                .Where(x => x.Number % 2 == 0).Select(y => y.Number);
            foreach (int i in even5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static bool isEven(int a)
        {
            return a % 2 == 0;
        }
    }
}
