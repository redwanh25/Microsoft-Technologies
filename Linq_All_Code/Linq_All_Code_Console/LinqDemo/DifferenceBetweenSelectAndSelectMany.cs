using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    class DifferenceBetweenSelectAndSelectMany
    {
        // difference : Select returns IEnumerable<List<string>> and SelectMany returns IEnumerable<string>

        public static void Main(string[] args)
        {
            // SelectMany_Example.cs file er moddhe Student class create kora ase.

            IEnumerable<List<string>> result = Student.GetAllStudetns().Select(s => s.Subjects);
            foreach (List<string> stringList in result)
            {
                foreach (string str in stringList)
                {
                    Console.WriteLine(str);
                }
            }

            Console.WriteLine("=========================");

            IEnumerable<string> result1 = Student.GetAllStudetns().SelectMany(s => s.Subjects);
            foreach (string str in result1)
            {
                Console.WriteLine(str);
            }

        }
    }
}
