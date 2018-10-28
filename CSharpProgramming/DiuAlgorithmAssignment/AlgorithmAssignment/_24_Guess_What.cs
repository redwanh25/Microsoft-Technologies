using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class _24_Guess_What
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n-- != 0)
            {
                string[] str = Console.ReadLine().Split();
                int guess = int.Parse(str[1]);
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int val = Array.Find(arr, i => i == guess);
                if (val == guess)
                {
                    Console.WriteLine((Array.IndexOf(arr, val) + 1));
                }
                else
                {
                    List<int> list = new List<int>();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        list.Add(arr[i]);
                    }
                    list.Add(guess);
                    list.Add(int.MinValue);
                    list.Add(int.MaxValue);
                    list.Sort();

                    int j = list.IndexOf(guess);

                    if (Math.Abs(list[j] - list[j - 1]) < Math.Abs(list[j] - list[j + 1]))
                    {
                        Console.WriteLine((Array.IndexOf(arr, list[j - 1]) + 1));
                    }
                    else if (Math.Abs(list[j] - list[j - 1]) == Math.Abs(list[j] - list[j + 1]))
                    {
                        if(Array.IndexOf(arr, list[j-1]) < Array.IndexOf(arr, list[j + 1]))
                        {
                            Console.WriteLine((Array.IndexOf(arr, list[j - 1]) + 1));
                        }
                        else
                        {
                            Console.WriteLine((Array.IndexOf(arr, list[j + 1]) + 1));
                        }
                    }
                    else
                    {
                        Console.WriteLine((Array.IndexOf(arr, list[j + 1]) + 1));
                    }
                }


            }
        }
    }
}
