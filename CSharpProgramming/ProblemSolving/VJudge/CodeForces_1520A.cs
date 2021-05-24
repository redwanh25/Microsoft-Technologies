using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.VJudge
{
    class CodeForces_1520A
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for(int i = 0; i < x; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Stack<char> stack = new Stack<char>();
                string str = Console.ReadLine();
                stack.Push(str[0]);
                for (int j = 1; j < n; j++)
                {
                    if(stack.Peek() != str[j])
                    {
                        stack.Push(str[j]);
                    }
                }
                int cnt1 = stack.Count();
                int cnt2 = stack.Distinct().Count();

                Console.WriteLine(cnt1 == cnt2 ? "YES": "NO");
            }
            //Console.ReadKey();
        }
    }
}
