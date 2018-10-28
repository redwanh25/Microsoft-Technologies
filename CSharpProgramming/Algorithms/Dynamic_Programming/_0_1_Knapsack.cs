using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class _0_1_Knapsack
    {
        public int KnapSack(int[] val, int[] wet, int weight)
        {
            int[][] arr = new int[val.Length][];
            arr = arr.Select(i => new int[weight + 1]).ToArray();

            //  total[0] = total.Select(i => 0).ToArray();  // array decleare korle by default shob gulo value 0 thake. aita deoyar dorkar nai.

            for (int i = 1; i < arr.Length; i++)
            {
                for (int w = 0; w < arr[i].Length; w++)
                {
                    if (w == 0)
                    {
                        arr[i][w] = 0;
                    }
                    else if (wet[i] <= w)
                    {
                        arr[i][w] = Math.Max((val[i] + arr[i - 1][w - wet[i]]), arr[i - 1][w]);
                    }
                    else
                    {
                        arr[i][w] = arr[i - 1][w];
                    }
                }
            }
            return arr[arr.Length - 1][weight];
        }

        public static void Main(String[] args)
        {
            String[] str = Console.ReadLine().Split();
            int v = Convert.ToInt32(str[0]);
            int w = Convert.ToInt32(str[1]);
            int weight = Convert.ToInt32(str[2]);

            String[] str1 = Console.ReadLine().Split();
            String[] str2 = Console.ReadLine().Split();

            int[] val = new int[v + 1];
            int[] wet = new int[w + 1];

            for (int i = 1; i <= v; i++)
            {
                val[i] = Convert.ToInt32(str1[i - 1]);
                wet[i] = Convert.ToInt32(str2[i - 1]);
            }
            _0_1_Knapsack obj = new _0_1_Knapsack();
            Console.WriteLine(obj.KnapSack(val, wet, weight));
        }
    }
}

/*

3 3 50
60 100 120
10 20 30
output = 220

3 3 50
120 100 60
30 20 10
output = 220

4 4 7
5 7 4 1
4 5 3 1
output = 9

4 4 7
1 4 5 7
1 3 4 5

*/
