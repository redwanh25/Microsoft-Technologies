using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces_Diff
{
    class Remove_Duplicates_978_problem_A
    {
        public static void Main(String[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List <int> arr = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();

            arr.Reverse();
            arr = arr.Distinct().ToList();

            arr.Reverse();
            Console.WriteLine(arr.Count);
            foreach (int it in arr)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
        }
    }
}

/*

6
1 5 5 1 6 1

1 6 1 5 5 1

1 6 5

5 6 1
*/
