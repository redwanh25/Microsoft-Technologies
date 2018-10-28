using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.NewFolder1
{
    class EngineFailure
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i = 1; i < x; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    Console.WriteLine(i+1);
                    return;
                }
            }
            Console.WriteLine("0");
        }
    }
}
