using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class Sort
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("redwan");
            list.Add("enan");
            list.Add("ratna");
            list.Add("belal");

            list.Sort();

            foreach (var li in list)
            {
                Console.WriteLine(li);
            }
        }
    }
}
