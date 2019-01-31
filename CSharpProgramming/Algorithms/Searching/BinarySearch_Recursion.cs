using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    class BinarySearch_Recursion
    {
        public static int binary_Search(int low, int high, int key, int[] arr)
        {
            if (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] > key)
                {
                    high = mid - 1;
                }
                else if (arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    Console.WriteLine("found");
                    return 1;
                }
                return binary_Search(low, high, key, arr);
            }
            return 0;
        }
        public static void Main(String[] args)
        {
            int[] a = { 1, 3, 6, 9, 10, 13, 17, 18, 20, 33, 34, 36, 45 };
            Array.Sort(a);
            int low = 0, high = a.Length - 1, key = 9;
            int x = binary_Search(low, high, key, a);
            if (x == 0)
            {
                Console.WriteLine("not found");
            }
        }
    }
}
