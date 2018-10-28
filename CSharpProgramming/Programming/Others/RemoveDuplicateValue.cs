using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Others
{
    class RemoveDuplicateValue
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            arr = arr.Distinct().ToArray();

            foreach (var it in arr)
            {
                Console.Write(it + " ");

            }
        }
    }
}
