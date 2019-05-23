using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class Besic1
    {
        public static void Main(string[] args)
        {
            // Create Customer Objects
            Customer2 customr1 = new Customer2()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer2 customr2 = new Customer2()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer2 customr3 = new Customer2()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            List<Customer2> list = new List<Customer2>();
            list.Add(customr1);
            list.Add(customr2);
            list.Add(customr3);

            Console.WriteLine(list[0].ID);
            Console.WriteLine(list[1].ID);
            Console.WriteLine(list[2].Name);
        }
    }
}
