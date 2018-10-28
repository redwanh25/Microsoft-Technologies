using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class __8_SelectionTest1
    {
        public static void Main(String[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = arr[0];
            int b = arr[1];
            int c = arr[2];
            int d = arr[3];
            if (b > c && d > a && (c + d) > (a + b) && c >= 0 && d >= 0 && a % 2 == 0)
                Console.Write("Valores aceitos\n");
            else
                Console.Write("Valores nao aceitos\n");
        }
    }
}
