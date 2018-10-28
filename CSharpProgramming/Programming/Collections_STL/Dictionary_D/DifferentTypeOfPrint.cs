using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.Dictionary_D
{
    class DifferentTypeOfPrint
    {
        public static void Main()
        {
            var d = new Dictionary<string, int>();
            d.Add("One", 1);
          //d.Add("Two", 2);    
          //d.Add("Two", 4);      // d.Add aita te vejal ase. dui ta key same paile e exception throw korbe.
            d["two"] = 2;         // aivabe korle key same paile exception throw kore na.
            d["two"] = 4;         // ai value ta update hoye jabe
            d["three"] = 3;

            foreach (KeyValuePair<string, int> kv in d)
                Console.WriteLine(kv.Key + "; " + kv.Value);

            List<String> list = d.Keys.ToList();
          //  var list = d.Keys;

            foreach (string s in list)
                Console.Write(s + " ");
            Console.WriteLine();

            foreach (int i in d.Values)
                Console.Write(i + " ");
            Console.WriteLine();

            foreach (string str in d.Keys)
                Console.Write(str + " ");
            Console.WriteLine();

            IEnumerator<int> it = d.Values.GetEnumerator();
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current);
            }


        }
    }
}
