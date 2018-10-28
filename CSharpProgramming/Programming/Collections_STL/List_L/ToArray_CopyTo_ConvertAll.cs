using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class ToArray_CopyTo_ConvertAll
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

            string[] wordsArray = words.ToArray();  // Creates a new typed array

            // Copy first two elements to the end of an existing array:
            string[] existing = new string[7];
            words.CopyTo(0, existing, 2, 4);    // CopyTo(int index, T[] array, int arrayIndex, int count);
       //   words.CopyTo(existing, 1);
       //   words.CopyTo(existing);

            foreach (var str in existing)
            {
                Console.WriteLine(str);
            }

            List<string> LowerCaseLatter = words.ConvertAll(s => s.ToLower());
            List<int> length = words.ConvertAll(s => s.Length);

            foreach (var str in LowerCaseLatter)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            foreach (var str in length)
            {
                Console.Write(str + " ");
            }
        }
    }
}
