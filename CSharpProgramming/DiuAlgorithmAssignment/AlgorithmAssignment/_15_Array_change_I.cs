using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class _15_Array_change_I
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0, j = 19; i < 20; i++, j--)
            {
                int x = int.Parse(Console.ReadLine());
                arr[j] = x;
            }
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
