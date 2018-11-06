using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.List_L
{
    class AsReadOnly_Method
    {
        public static void Main(string[] args)
        {
            // Create Customer Objects
            Customer customr1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customr2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customr3 = new Customer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            List<Customer> list = new List<Customer>();
            list.Add(customr1);
            list.Add(customr2);
            list.Add(customr3);

            ReadOnlyCollection<Customer> readOnlyCollection = list.AsReadOnly();
            Customer cs = readOnlyCollection[0];
            Console.WriteLine(cs.ID + " " + cs.Name + " " + cs.Salary);
            Console.WriteLine(readOnlyCollection.Count);

            Console.WriteLine();

            // readOnlyCollection[0] = customr2;    amra ai kaj ta korte parbo na.
            // readonly te shudu value pora jay. kono modify kora jay na.

            foreach (var k in list)
            {
                Console.WriteLine(k.Name);
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
