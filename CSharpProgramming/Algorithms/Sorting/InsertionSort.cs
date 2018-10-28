using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class InsertionSort
    {
        public void InsertionSortMethod(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int val = arr[i];
                int h = i;
                while (h > 0 && arr[h-1] > val)
                {
                    arr[h] = arr[h - 1];
                    h--;
                }
                arr[h] = val;
            }
        }

        public static void Main(string[] args)
        {
            InsertionSort IS = new InsertionSort();
            int[] arr = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            IS.InsertionSortMethod(arr);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
