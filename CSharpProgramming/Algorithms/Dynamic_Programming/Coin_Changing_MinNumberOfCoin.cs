using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class Coin_Changing_MinNumberOfCoin
    {
        public static void Main(String[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            int[] list = new int[sum + 1];
            list = list.Select(i => int.MaxValue).ToArray();
            list[0] = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 1; j < list.Length; j++)
                {
                    if(arr[i] <= j && list[j - arr[i]] != int.MaxValue)
                    {
                        list[j] = Math.Min(list[j], list[j - arr[i]] + 1);
                    }
                }
            }
            Console.WriteLine(list[sum]);
        }
    }
}

/*

9 6 5 1
11

1 5 6 8
11
op : 2

8 6 1 5
11
op : 2

1 1 1 1
8

*/
