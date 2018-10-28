using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.LinkedList_LL
{
    class First_Last_AddLast_AddFirst_RemoveFirst_RemoveLast
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            var names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");//added to first index

            String first = names.First();
            String last = names.Last();

            Console.WriteLine(first + " " + last);

            names.RemoveFirst();
            names.RemoveLast();

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
