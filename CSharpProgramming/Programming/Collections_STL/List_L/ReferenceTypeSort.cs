using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{

    class Person
    {
        private int first;
        private int second;
        public Person(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
        public int getFirst()
        {
            return first;
        }
        public int getSecond()
        {
            return second;
        }
    }

    class ReferenceTypeSort
    {
        public static void Main(String[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person(3, 2));
            list.Add(new Person(1, 1));
            list.Add(new Person(4, 4));
            list.Add(new Person(2, 3));

                    list.Sort((pair1, pair2) => pair1.getFirst().CompareTo(pair2.getFirst()));
            //      list.Sort((pair1, pair2) => pair1.getSecond().CompareTo(pair2.getSecond()));
            //      list = list.OrderBy(it => it.getFirst()).ToList();
            //      list = list.OrderBy(it => it.getSecond()).ToList();
            //      list = list.OrderByDescending(it => it.getFirst()).ToList();
            //      list = list.OrderByDescending(it => it.getSecond()).ToList();

            foreach (Person it in list)
            {
                Console.WriteLine(it.getFirst() + " " + it.getSecond());
            }

        }
    }
}
