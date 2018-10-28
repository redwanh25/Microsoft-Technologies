using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class Reverse_Sort_IEnumerator
    {
        public static void Main(String[] args)
        {
            string str = "redwan hossain";
            char[] ch = str.ToArray();

            string s2 = new string(ch);

            Array.Sort(ch);

            string[] st = { "b", "a", "d", "c" };
            Array.Sort(st);
            
            Console.WriteLine(ch);
            Console.WriteLine(s2 + " " + ch.Length);

            string srr = "";
            IEnumerator it = st.GetEnumerator();
            while (it.MoveNext())
            {
                 srr += it.Current;     // it.Current.ToString();
                Console.WriteLine(srr);
            }
        }
    }
}
