using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All
{
    class Copy_CopyTo
    {
        public static void Main(String[] args)
        {
            int[] arraySrc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();         // 1 2 3 4 5 6
       //   int[] arrayDest = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayDest = new int[arraySrc.Length];
            Array.Copy(arraySrc, arrayDest, 3);     //  1 2 3 0 0 0
            foreach (int i in arrayDest)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] arrDest = new int[20];

            arr.CopyTo(arrDest, 2);         // 0 0 1 2 3 4 5 6 0 0 0 0 0 0 0 0 0 0 0 0
    //        arr.CopyTo(arrDest, 0);         // 1 2 3 4 5 6 0 0 0 0 0 0 0 0 0 0 0 0 0 0
            foreach (int i in arrDest)  
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
