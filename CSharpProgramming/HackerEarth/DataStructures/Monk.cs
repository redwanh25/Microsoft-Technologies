using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.DataStructures
{
    class Monk
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i] + arr1[i]);
            }
        }
    }
}
