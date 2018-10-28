using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Others
{
    class DuplicateOperation_veryImportant
    {
        public static void Main()
        {
            int[] arr = { 4, 2, 3, 1, 6, 4, 3 };
            var anyDuplicate = arr.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToArray();

            foreach (var it in anyDuplicate)
            {
                Console.Write(it + " ");
            }

            Console.WriteLine();

            int[] arr1 = { 4, 2, 3, 1, 6, 4, 3 };
            var allUnique = arr1.GroupBy(x => x).Where(g => g.Count() == 1).Select(y => y.Key).ToArray();

            foreach (var it in allUnique)
            {
                Console.Write(it + " ");
            }

            Console.WriteLine();

            int[] arr2 = { 4, 2, 3, 1, 6, 4, 3 };
            var UniqueValue = arr2.GroupBy(x => x).Where(g => g.Count() >= 1).Select(y => y.Key).ToArray();

            foreach (var it in UniqueValue)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
        }
    }
}
