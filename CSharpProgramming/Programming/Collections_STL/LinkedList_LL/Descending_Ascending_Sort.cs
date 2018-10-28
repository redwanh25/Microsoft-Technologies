using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.LinkedList_LL
{
    class Descending_Ascending_Sort
    {
        public static void Main(String[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");

            names = new LinkedList<String>(names.OrderBy(i => i));      // Ascending order sort
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            names = new LinkedList<String>(names.OrderByDescending(i => i));        // Discending order sort
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            LinkedList<Tuple<int, int>> linked = new LinkedList<Tuple<int, int>>();
            linked.AddLast(Tuple.Create(1, 2));
            linked.AddLast(Tuple.Create(4, 3));
            linked.AddLast(Tuple.Create(2, 4));
            linked.AddLast(Tuple.Create(3, 1));
            linked.AddLast(Tuple.Create(0, 5));

            linked = new LinkedList<Tuple<int, int>>(linked.OrderBy(i => i.Item1));
            foreach (var name in linked)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }
    }
}
