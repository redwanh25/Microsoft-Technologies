using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class MergeSort
    {
        public void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1 + 1];
            int[] R = new int[n2 + 1];
            int i, j;
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[left + i];
            }
            for(j = 0; j < n2; j++)
            {
                R[j] = arr[mid+1 + j];
            }
            L[i] = R[j] = int.MaxValue;
            for(int l = 0, r = 0, k = left; k <= right; k++)
            {
                if(L[l] <= R[r])
                {
                    arr[k] = L[l];
                    l++;
                }
                else
                {
                    arr[k] = R[r];
                    r++;
                }
            }
        }

        public void MergeSortMethod(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSortMethod(arr, left, mid);
                MergeSortMethod(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }

        }

        public static void Main(string[] args)
        {
            MergeSort ms = new MergeSort();
            int[] arr = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            ms.MergeSortMethod(arr, 0, arr.Length-1);

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

// 2 4 1 6 8 5 3 7