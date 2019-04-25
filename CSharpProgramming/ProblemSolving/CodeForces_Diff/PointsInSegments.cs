using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces_Diff
{
    class PointsInSegments
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = arr[0];
            int m = arr[1];
            int[] res = new int[m];
            int k = 1;
            res = res.Select(i => k++).ToArray();       // 1 2 3 4 5 6 7 . . . . . . m

            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.Write(res[i] + " ");
            //}

            for(int i = 0; i < n; i++)
            {
                int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = arr1[0]-1; j < arr1[1]; j++)
                {
                    res[j] = 0;
                }
            }

            int cnt = 0;
            string str = "";
            foreach(int i in res)
            {
                if (i != 0)
                {
                    cnt++;
                    str += i + " ";
                }
            }
            Console.WriteLine(cnt);
            Console.WriteLine(str);
        }
    }
}
