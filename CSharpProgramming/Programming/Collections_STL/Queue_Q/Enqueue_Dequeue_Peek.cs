using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.Queue_Q
{
    class Enqueue_Dequeue_Peek
    {
        public static void Main(String[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue(4);
            queue.Enqueue(3);

            foreach (var it in queue)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
            Console.WriteLine(queue.Peek());
            while(queue.Count() != 0)
            {
                int i = queue.Dequeue();
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
