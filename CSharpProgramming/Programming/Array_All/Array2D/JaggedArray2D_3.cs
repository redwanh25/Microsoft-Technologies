using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All.Array2D
{
    class JaggedArray2D_3
    {
        public static void Main(String[] args)
        {
            //double[][] ServicePoint = new double[10][9]; // <-- gives an error (1)
            //double[][] ServicePoint = new double[10][]; // <-- ok (2)
            //double[,] ServicePoint = new double[10, 9]; // <-- ok (3)

            //int[] p = { 1, 2, 3 };
            //int[] q = { 4, 5, 6 };
            //int[][] arr = new int[][] { p, q};

            int[][] arr = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7, 8} };
         // int[][] arr = new int[2][] { { 1, 2, 3 }, { 4, 5, 6, 7, 8 } };   //   <-- not ok
         // int[,] myArray = { { 1, 2, 3}, { 3, 4, 4 }, { 5, 6, 4 }, { 7, 8, 6 } };    //    <-- ok

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
