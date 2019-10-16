using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.DataStructures
{
    class Memorise_Me
    {
        public static void Main(string[] arg)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr1 = new int[1001];
            for (int i = 0; i < n; i++)
            {
                arr1[arr[i]]++;
            }
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (arr1[value] != 0)
                {
                    int cnt = arr1[value];
                    Console.WriteLine(cnt);
                }
                else
                {
                    Console.WriteLine("NOT PRESENT");
                }
            }
        }
    }
}
