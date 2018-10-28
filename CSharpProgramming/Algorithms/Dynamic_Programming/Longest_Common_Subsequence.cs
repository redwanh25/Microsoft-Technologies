using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class Longest_Common_Subsequence
    {
        public int longestCommmonSubsequence(string s1, string s2)
        {
            int[][] arr = new int[s1.Length+1][];
            arr = arr.Select(i => new int[s2.Length + 1]).ToArray();
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    if(i == 0 || j == 0)
                    {
                        arr[i][j] = 0;
                    }
                    else if (s1[i-1].Equals(s2[j-1]))
                    {
                        arr[i][j] = arr[i - 1][j - 1] + 1;
                    }
                    else
                    {
                        arr[i][j] = Math.Max(arr[i][j-1], arr[i-1][j]);
                    }
                }
            }
            return arr[s1.Length][s2.Length];
        }
        public static void Main(String[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Longest_Common_Subsequence lcs = new Longest_Common_Subsequence();
            Console.WriteLine(lcs.longestCommmonSubsequence(s1, s2));
        }
    }
}

/*
redwan
wrdxan
*/
