using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class __7_TheGreatest
    {
        public static void Main(string[] args)
        {
            int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(str.Max() + " eh o maior");     
        }
    }
}
