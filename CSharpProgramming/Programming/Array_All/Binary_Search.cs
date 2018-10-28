using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All
{
    class Binary_Search
    {
        public static void Main(String[] arg)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int index1 = Array.BinarySearch(arr, 0, 3, 2);          // BinarySearch(Array, Int32(inclusive), Int32(exclusive), Object)
            int index2 = Array.BinarySearch(arr, 4);                // BinarySearch(Array, Object)
            int index3 = Array.BinarySearch(arr, 9);
            Console.WriteLine("{0} {1} {2}", index1, index2, index3);

            string[] array = { "a", "e", "m", "n", "x", "z" };

            int index4 = Array.BinarySearch(array, "m");
            int index5 = Array.BinarySearch<string>(array, "x");

            Console.WriteLine(index4 + " " + index5);

            Console.WriteLine(Array.BinarySearch(array, "E") >= 0 ? "ase" : "Nai");

        //  Array.BinarySearch(array, "E") >= 0 ? Console.WriteLine("ase") : Console.WriteLine("Nai");
        //  ai vabe likhle hobe na..

            Console.ReadKey();

        }
    }
}
