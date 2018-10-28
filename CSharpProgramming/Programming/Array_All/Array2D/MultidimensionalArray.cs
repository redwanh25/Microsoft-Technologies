using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Two-dimensional GetLength example.
// int[,] two = new int[5, 10];
// Console.WriteLine(two.GetLength(0)); // Writes 5
// Console.WriteLine(two.GetLength(1)); // Writes 10

namespace Programming.Array_All.Array2D
{
    class MultidimensionalArray
    {
        public static void Main(String[] args)
        {
      //    int[,] myArray = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };        <-- Ok

            int[,] arr = new int[2, 3];     //declaration of 2D array  
            for (int i = 0; i < arr.GetLength(0); i++)      // GetLength(0) mane [aita, ]
            {
                int[] numList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < arr.GetLength(1); j++)  // GetLength(1) mane [ , aita]
                {
                    arr[i, j] = numList[j];
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
