using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class Longest_Increasing_Subsequence
    {
        public static void Main(String[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] list = new int[arr.Length];
            list = list.Select(i => 1).ToArray();

            for(int i = 1; i < arr.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(arr[j] < arr[i])
                    {
                        list[i] = Math.Max(list[j] + 1, list[i]);
                    }
                }
            }
            int lis = list.Max();
            Console.WriteLine(lis);
        }
    }
}

/*

3 4 -1 0 8 2 3

10 22 9 33 21 50 41 60

*/
