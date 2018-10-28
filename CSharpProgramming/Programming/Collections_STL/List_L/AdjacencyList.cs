using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class AdjacencyList
    {
        private List<int>[] list;

        public AdjacencyList()
        {
            list = new List<int>[5];
            list = list.Select(i => new List<int>()).ToArray();
            //for (int i = 0; i < 5; i++)
            //{
            //    list[i] = new List<int>();
            //}
        }

        public void add()
        {
            list[0].Add(1); list[0].Add(2); list[0].Add(3);
            list[1].Add(4); list[1].Add(5);
            list[2].Add(6);
            list[3].Add(7); list[3].Add(8);
            list[4].Add(9); list[4].Add(10); list[4].Add(11);
        }

        public static void Main(String[] args)
        {
            List<int>[] list_dj = new List<int>[3];
            for (int k = 0; k < 3; k++)
            {
                list_dj[k] = new List<int>();
            }
            list_dj[0].Add(1); list_dj[0].Add(2); list_dj[0].Add(3);
            list_dj[1].Add(4); list_dj[1].Add(5);
            list_dj[2].Add(6);

            for(int l = 0; l < list_dj.Length; l++)
            {
                for(int m = 0; m < list_dj[l].Count; m++)
                {
                    Console.Write(list_dj[l][m] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            AdjacencyList al = new AdjacencyList();
            al.add();
            Console.WriteLine(al.list[4][2] + "\n");

            int i = 0;
            while (al.list.Count() > i)
            {
                IEnumerator<int> it1 = al.list[i++].GetEnumerator();
                while (it1.MoveNext())
                {
                    Console.Write(it1.Current + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (var it in al.list)
            {
                foreach(var j in it)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
