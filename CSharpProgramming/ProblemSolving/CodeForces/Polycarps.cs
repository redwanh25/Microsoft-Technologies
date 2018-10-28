using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces
{
    class Polycarps
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] cnt = new int[200];
            cnt = cnt.Select(i => 0).ToArray();

            for(int i = 0; i < arr.Length; i++)
            {
                cnt[arr[i]]++;
            }

            int maxValue = cnt.Max();
            Console.WriteLine(maxValue);
        }
    }
}
