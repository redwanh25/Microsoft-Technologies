using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    class Partitioning_Operators
    {
        public static void Main(string[] args)
        {
            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };

            IEnumerable<string> result = countries.Take(3);
            foreach (string country in result)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine("=========================1");

            IEnumerable<string> result1 = countries.Skip(3);
            foreach (string country in result1)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine("=========================2");

            IEnumerable<string> result2 = countries.TakeWhile(s => s.Length > 3);
            foreach (string country in result2)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine("=========================3");

            IEnumerable<string> result3 = countries.SkipWhile(s => s.Length > 2);
            foreach (string country in result3)
            {
                Console.WriteLine(country);
            }
        }
    }
}
