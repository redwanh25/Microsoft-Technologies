using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All.Array2D
{
    class JaggedArray2D_1
    {
        public static void Main(String[] arg)
        {
            int[][] arr = new int[2][];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            foreach(int[] i in arr)
            {
                foreach(int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

//input :
//1 2 3 4 5
//6 7 8 9 10 12 34