using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainstation
{
    class Problem_C
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var w = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var x = Console.ReadLine();

            var r = new int[2 * n];
            var tS = new Queue<int>(Enumerable.Range(0, n).OrderBy(i => w[i]).Select(i => i + 1));
            var oS = new Stack<int>();

            for (int i = 0; i < 2 * n; i++)
            {
                if (x[i] == '0')
                {
                    r[i] = tS.Peek();
                    oS.Push(tS.Dequeue());
                }
                else
                {
                    r[i] = oS.Pop();
                }
            }

            Console.WriteLine(string.Join(" ", r));
        }
    }
}
