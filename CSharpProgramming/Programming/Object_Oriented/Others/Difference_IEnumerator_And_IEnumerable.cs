using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Others
{
    class Difference_IEnumerator_And_IEnumerable
    {
        public static void Main(String[] args)
        {
            List<int> Month = new List<int>();
            Month.Add(1);
            Month.Add(2);
            Month.Add(3);
            Month.Add(4);
            Month.Add(5);

            IEnumerable<int> it = Month;
            foreach(int str in it)       // IEnumerable er jonno foreach loop
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            IEnumerator<int> it1 = Month.GetEnumerator();
            while (it1.MoveNext())          // IEnumerator er jonno foreach loop kaj korbe na. 
            {                               // ai way te kaj korte hobe.
                Console.WriteLine(it1.Current);
            }
            Console.WriteLine();

            IEnumerator<int> it2 = Month.GetEnumerator();
            print_1_to_3(it2);

            IEnumerable<int> it3 = Month;
            print(it3);

        }

        // IEnumerator position dhore rakhte pare.

        public static void print_1_to_3(IEnumerator<int> it)
        {
            Console.WriteLine("IEnumerator position dhore rakhte pare");
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current);
                if(it.Current > 3)
                {
                    print_4_to_5(it);
                }
            }
        }
        public static void print_4_to_5(IEnumerator<int> it1)
        {
            while (it1.MoveNext())
            {
                Console.WriteLine(it1.Current);
            }
        }

        // IEnumerable position dhore rakhte pare na.

        public static void print(IEnumerable<int> it)
        {
            Console.WriteLine("IEnumerable position dhore rakhte pare na");
            foreach (int str in it)       // IEnumerable er jonno foreach loop
            {
                Console.WriteLine(str);
                if(str > 3)
                {
                    print1(it);
                }
            }
        }
        public static void print1(IEnumerable<int> it1)
        {
            foreach (int str in it1)       // IEnumerable er jonno foreach loop
            {
                Console.Write(str);
            }
            Console.WriteLine();
        }
    }
}
