using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All
{
    class Reverse_Sort_IndexOf
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[10];
            arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(arr);
            Array.Reverse(arr);         // codeforces a Array.Reverse(arr) aita ney na. runtime error show kore. but, sort er ta abr ney.
                                        // Seems that Mono C# doesn't know about Array.Reverse()
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));
            Console.WriteLine();
        }
    }
}
