using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class AddSubClass
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

            Customer2SubClass csc = new Customer2SubClass()
            {
                ID = 15,
                Name = "Redwan",
                Salary = 10500
            };

            list.Add(csc);      // list a reference type er moddhe shudhu oi class and oi class er subclass k add kora jabe.

            foreach (var k in list)
            {
                Console.WriteLine(k.Name);
            }
        }
    }
    public class Customer2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class Customer2SubClass : Customer2
    {

    }
}
