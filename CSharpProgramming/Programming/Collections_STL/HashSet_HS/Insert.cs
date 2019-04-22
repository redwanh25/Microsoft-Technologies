using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.HashSet_HS
{
    class Insert
    {
        public static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");//will not be added

            // Iterate HashSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names = names.OrderBy(i => i).ToHashSet();     // Ascending order sort
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            names = new HashSet<String>(names.OrderByDescending(i => i));        // Discending order sort
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
