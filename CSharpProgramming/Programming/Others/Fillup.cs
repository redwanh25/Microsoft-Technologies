using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Others
{
    class Fillup
    {
        public static void Main(string[] args)
        {
            List<int> list = Enumerable.Range(0, 10).Select(i => 12).ToList();
            foreach(int it in list)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();

            int[] arr = new int[10];
            arr = arr.Select(i => 13).ToArray();
            foreach (int it in arr)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();

            int[] arr1 = new int[10];
            arr1 = Enumerable.Repeat(42, 5).ToArray();
            for (int i = 0; i < arr1.Length; i++)       // becareful. akhun kintu array 0-4 porjonto index hoye gese..
            {
                Console.WriteLine(arr1[i] + " " + i);
            }
            Console.WriteLine();
        }
    }
}
