using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.Dictionary_D
{
    class SortByValue_InList
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("4", "Peter");
            names.Add("5", "James");
            names.Add("3", "Aatan");
            names.Add("2", "Aatan");
// one way
//            List<KeyValuePair<string, string>> myList = names.ToList();
            var myList = names.ToList();
            myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            // two way
            //names = names.OrderBy(i => i.Value);                  // its not gonna work
            //var ordered = names.OrderBy(x => x.Value).ToList();   // it is working
            var ordered = names.OrderBy(x => x.Value);
// three way
            List<KeyValuePair<string, string>> my = names.ToList();
            my.Sort(delegate (KeyValuePair<string, string> pair1, KeyValuePair<string, string> pair2) {
                    return pair1.Value.CompareTo(pair2.Value);
                }
            );

            foreach(var item in names)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            foreach (var item in names.OrderBy(i => i.Value))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (KeyValuePair<string, string> kv in myList)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kv in ordered)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kv in my)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
