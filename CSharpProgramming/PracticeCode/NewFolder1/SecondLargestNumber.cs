using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.NewFolder1
{
    class SecondLargestNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var max = arr[0];
            var index = 0;
            for(var i = 0; i < n; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            Console.WriteLine(max);
            var max2 = arr[0];
            for (var i = 0; i < n; i++)
            {
                if(arr[i] > max2 && index != i)
                {
                    max2 = arr[i];
                }
            }
            Console.WriteLine(max2);
        }
    }
}

//5
//-2147483640 1 2 3 2147483640