using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.Stack_S
{
    class Push_Pop_Peek
    {
        public static void Main(String[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(1);
            stack.Push(4);
            stack.Push(3);

            foreach (var it in stack)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
            Console.WriteLine(stack.Peek());
            while (stack.Count() != 0)
            {
                //stack.Pop();
                int i = stack.Pop();
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
