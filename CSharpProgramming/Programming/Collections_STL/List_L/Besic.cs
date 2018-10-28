using System;
using System.Collections.Generic;

namespace Programming.Collections_STL.List_L
{
    class Besic
    {
        public static void Main(String[] args)
        {
         // List<string> names = new List<string>() { "Sonoo", "Vimal", "Ratan", "Love" };  // both are right
            var names = new List<string>() { "Sonoo", "Vimal", "Ratan", "Love" };
            foreach (String it in names)
            {
                Console.WriteLine(it);
            }
            Console.WriteLine();

            List<string> list = new List<string>();
            list.Add("redwan");
            list.Add("enan");
            list.Add("ratna");
            list.Add("belal");

            IEnumerator<string> it1 = list.GetEnumerator();
            while (it1.MoveNext())
            {
                Console.WriteLine(it1.Current);
            }

            Console.WriteLine();

            foreach (var it2 in list)
            {
                string a = it2;
                Console.WriteLine(a + " " + it2);
            }
            Console.WriteLine("\n" + list[3]);
        }
    }
}
