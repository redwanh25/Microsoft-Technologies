using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class Count_GetRange_Clear_Contains
    {
        public static void Main()
        {
            //Create a List of Strings
            //String-typed list
            List<string> words = new List<string>();

            words.Add("A");
            words.Add("B");
            words.Add("C");
            words.Add("D");
            words.Add("E");
            words.Add("F");


            Console.WriteLine("First:" + words[0]);  // first word 
            Console.WriteLine("Last:" + words[words.Count - 1]);  // last word 

            foreach (string s in words)
                Console.WriteLine("all:" + s);   // all words 

            List<string> subset = words.GetRange(1, 2); // 2nd->3rd words

        //  IList<string> subset = words.GetRange(1, 2); // 2nd->3rd words
      //    The List is an implementation of the IList Interface

            foreach (var str in subset)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(subset.Contains("A") ? "yes" : "no");
            Console.WriteLine(subset.Contains("B") ? "yes" : "no");
            Console.WriteLine(words.Count);
            words.Clear();
            Console.WriteLine(words.Count);
        }
    }
}
