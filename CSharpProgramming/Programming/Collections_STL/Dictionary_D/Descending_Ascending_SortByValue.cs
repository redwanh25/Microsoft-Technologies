using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.Dictionary_D
{
    class Descending_Ascending_SortByValue
    {
        public static void Main(String[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("2", "Aatan");
            names.Add("4", "Peter");
            names.Add("5", "James");
            names.Add("3", "Aatan");
            names.Add("1", "Sonoo");

            //   or    names = names.OrderByDescending(keySelector: u => u.Value).ToDictionary(keySelector: z => z.Key, elementSelector: y => y.Value);
            names = names.OrderByDescending(u => u.Value).ToDictionary(z => z.Key, y => y.Value);   // descending
            foreach (KeyValuePair<string, string> it in names)
            {
                Console.WriteLine(it.Key + " " + it.Value);
            }

            Console.WriteLine();

            names = names.OrderBy(u => u.Key).ToDictionary(z => z.Key, y => y.Value);             // ascending
            foreach (KeyValuePair<string, string> it in names)
            {
                Console.WriteLine(it.Key + " " + it.Value);
            }
        }
    }
}
