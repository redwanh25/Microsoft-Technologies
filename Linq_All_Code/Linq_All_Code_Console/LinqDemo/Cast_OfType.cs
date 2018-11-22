using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    public class Cast_OfType
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            IEnumerable<int> list = arrayList.Cast<int>();
            foreach(int i in list)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine();

            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add(2);
            arrayList1.Add(3);
            arrayList1.Add("red");
            arrayList1.Add("wan");
            IEnumerable<int> list1 = arrayList1.OfType<int>();
            foreach (int i in list1)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            IEnumerable<string> list2 = arrayList1.OfType<string>();
            foreach (string i in list2)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
