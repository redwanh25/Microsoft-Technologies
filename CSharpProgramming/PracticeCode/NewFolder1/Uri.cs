using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.NewFolder1
{
    class Uri
    {
        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            bool ck = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i][j] == 42 && arr[i - 1][j - 1] == 7 && arr[i - 1][j] == 7 && arr[i - 1][j + 1] == 7 && arr[i][j - 1] == 7 && arr[i][j + 1] == 7 && arr[i + 1][j - 1] == 7 && arr[i + 1][j] == 7 && arr[i + 1][j + 1] == 7)
                    {
                        ck = true;
                        Console.WriteLine((i + 1) + " " + (j + 1));
                    }
                }
            }
            if(ck == false) Console.WriteLine(0 + " " + 0);
        }
    }
}