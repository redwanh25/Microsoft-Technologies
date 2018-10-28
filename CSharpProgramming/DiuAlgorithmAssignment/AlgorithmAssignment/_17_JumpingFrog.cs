using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class _17_JumpingFrog
    {
        public static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split();
            int jump = int.Parse(str1[0]);
            long[] str2 = Console.ReadLine().Split().Select(long.Parse).ToArray();
            for(int i = 1; i < str2.Length; i++)
            {
                if (Math.Abs(str2[i] - str2[i-1]) > jump)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
            }
            Console.WriteLine("YOU WIN");
        }
    }
}
