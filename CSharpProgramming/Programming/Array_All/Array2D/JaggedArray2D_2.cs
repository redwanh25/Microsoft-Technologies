using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All.Array2D
{
    class JaggedArray2D_2
    {
        public static void Main(String[] arg)
        {
            int[][] arr = new int[2][];

         //   arr = arr.Select(i => new int[4]).ToArray();
            
            arr[0] = new int[4];        // ami jodi user theke input na niye kono value assign kori taile amk ai vabe declere kore dite hobe.
            arr[1] = new int[6];        // noile error hobe.  mane ai dui ta line na likhe amra arr[0][1] = 5; aita likhte partam na.

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            foreach (int[] i in arr){
                foreach (int j in i){
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
// 1 2 3 4 5 6 7 8 9 10 11
// 12 3 44 5 6 7
// amra jokhon aita input a dibo tokhon 
// new int[4]; new int[6]; aita bere jabe. giye hoye jabe
// arr[0] = new int[11];
// arr[1] = new int[6];