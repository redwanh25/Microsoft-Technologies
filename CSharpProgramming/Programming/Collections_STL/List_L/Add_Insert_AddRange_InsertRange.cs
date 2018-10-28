using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class Add_Insert_AddRange_InsertRange
    {
        public static void Main()
        {
            //Create a List of Strings
            //String-typed list
            List<string> words = new List<string>();

            words.Add("A");
            words.Add("B");
            words.AddRange(new[] { "C", "D" });
            words.Insert(0, "X"); // Insert at start 
            words.InsertRange(0, new[] { "E", "F" });

            IEnumerator<string> it = words.GetEnumerator();
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current);
            }
        }
    }
}
