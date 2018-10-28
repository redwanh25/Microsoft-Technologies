using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class Remove_RemoveAll_RemoveAt_RemoveRange
    {
        public static void Main()
        {
            //Create a List of Strings
            //String-typed list
            List<string> words = new List<string>();

            words.Add("A");
            words.Add("B");
            words.Add("C");
            words.Add("Des");
            words.Add("E");
            words.Add("F");
            words.Add("Des");

            words.Remove("A");
            words.RemoveAt(3);  // Remove the 4th element 
            words.RemoveRange(0, 2); // Remove first 2 elements

            // Remove all strings starting in 'n':
            words.RemoveAll(s => s.StartsWith("D"));

            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
