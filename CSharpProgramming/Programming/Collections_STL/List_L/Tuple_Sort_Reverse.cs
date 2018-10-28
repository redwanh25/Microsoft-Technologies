using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming.Collections_STL.List_L
{
    class Tuple_Sort_Reverse
    {
        public static void Main(String[] args)
        {
            List<Tuple<int, string>> list = new List<Tuple<int, string>>();
            list.Add(new Tuple<int, string>(1, "Hello"));
            list.Add(Tuple.Create(4, "Peter"));
            list.Add(Tuple.Create(5, "James"));
            list.Add(new Tuple<int, string>(3, "Aatan"));
            list.Add(Tuple.Create(2, "Aatan"));

            list.Sort();
         //   list = new List<Tuple<int, string>>(list.OrderBy(i => i.Item1));

            IEnumerator<Tuple<int, string>> itt = list.GetEnumerator();
            while (itt.MoveNext())
            {
                Console.WriteLine(itt.Current.Item1 + " " + itt.Current.Item2);
            }
            Console.WriteLine();

            foreach (Tuple<int, string> it in list)
            {
                Console.WriteLine(it.Item1 + " " + it.Item2);
            }

            Console.WriteLine();

            List<Tuple<int, string, double>> list1 = new List<Tuple<int, string, double>>();
            list1.Add(new Tuple<int, string, double>(1, "Hello", 1.2));
            list1.Add(Tuple.Create(4, "Peter", 2.2));
            list1.Add(Tuple.Create(5, "James", 3.2));
            list1.Add(new Tuple<int, string, double>(3, "Aatan", 4.2));
            list1.Add(Tuple.Create(2, "Aatan", 5.2));

      //    list1.Sort((x, y) => x.Item2.CompareTo(y.Item2));
            list1 = list1.OrderBy(i => i.Item2).ToList();       // using System.Linq;   ai ta likhte hobe

            IEnumerator<Tuple<int, string, double>> itt1 = list1.GetEnumerator();
            while (itt1.MoveNext())
            {
                Console.WriteLine(itt1.Current.Item1 + " " + itt1.Current.Item2 + " " + itt1.Current.Item3);
            }
            Console.WriteLine();

            foreach (Tuple<int, string, double> it in list1)
            {
                Console.WriteLine(it.Item1 + " " + it.Item2 + " " + it.Item3);
            }
        }
    }
}
