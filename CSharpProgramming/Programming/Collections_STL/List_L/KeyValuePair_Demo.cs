using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class KeyValuePair_Demo
    {
        public static void Main(String[] args)
        {
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            list.Add(new KeyValuePair<int, string>(1, "Sonoo"));
            list.Add(new KeyValuePair<int, string>(4, "Peter"));
            list.Add(new KeyValuePair<int, string>(5, "James"));
            list.Add(new KeyValuePair<int, string>(3, "Aatan"));
            list.Add(new KeyValuePair<int, string>(2, "Aatan"));

            Console.WriteLine(list[4].Key);

            list.Sort((p1, p2) => p1.Key.CompareTo(p2.Key));

            IEnumerator<KeyValuePair<int, string>> itt = list.GetEnumerator();
            while (itt.MoveNext())
            {
                Console.WriteLine(itt.Current.Key + " " + itt.Current.Value);
            }
            Console.WriteLine();

            list = list.OrderBy(it => it.Value).ToList();

            foreach (KeyValuePair<int, string> it in list)
            {
                Console.WriteLine(it.Key + " " + it.Value);
            }
        }
    }
}
