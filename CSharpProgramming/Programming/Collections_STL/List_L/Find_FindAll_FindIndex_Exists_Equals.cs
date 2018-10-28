using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class Find_FindAll_FindIndex_Exists_Equals
    {
        public static void Main(String[] args)
        {
            List<string> list = new List<string>();
            list.Add("redwan");
            list.Add("enan");
            list.Add("belal");
            list.Add("ratna");
            list.Add("belal");

            int index;
            String str;
            string[] arr = new string[10];
            List<string> list1 = new List<string>();
            if (list.Find(s => s.Equals("redwan")) != null)     // return string or null
            {
                str = list.Find(s => s.Equals("redwan"));
                Console.WriteLine(str);
                index = list.FindIndex(s => s.Equals("rana"));      // khuje paile index number na paile -1
                Console.WriteLine(index);
                index = list.FindIndex(s => s.Equals("belal"));
                Console.WriteLine(index);
                arr = list.FindAll(s => s.Contains("belal")).ToArray();
                list1 = list.FindAll(s => s.Equals("belal"));
            }
            Console.WriteLine(list.Exists(s => s.Equals("redwan")) ? "ase" : "nai");
            foreach(var it in list1)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
            foreach (var it in arr)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();

            //int guess = int.Parse(str[1]);
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int val = Array.Find(arr, i => i == guess);
            //if (val == guess)
            //{
            //    Console.WriteLine((Array.IndexOf(arr, val) + 1));
            //}
        }

    }
}
