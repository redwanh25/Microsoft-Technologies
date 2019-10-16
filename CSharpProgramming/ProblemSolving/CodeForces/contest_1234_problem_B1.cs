using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces
{
    class contest_1234_problem_B1
    {
        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int k = int.Parse(str[1]);
            List<int> list = new List<int>();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i = 0; i < n; i++)
            {
                
                if(!list.Exists(a => a.Equals(arr[i])))
                {
                    list.Insert(0, arr[i]);
                }
                if (list.Count() == k+1)
                {
                    list.RemoveAt(k);
                }                
            }
            Console.WriteLine(list.Count());
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
