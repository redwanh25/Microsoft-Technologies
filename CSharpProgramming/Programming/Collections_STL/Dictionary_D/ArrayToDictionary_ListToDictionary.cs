using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.Dictionary_D
{
    class ArrayToDictionary_ListToDictionary
    {
        public static void Main(string[] args)
        {
            // Create Customer Objects
            Customer1 customr1 = new Customer1()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer1 customr2 = new Customer1()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer1 customr3 = new Customer1()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            Customer1[] arrayCustomers = new Customer1[3];
            arrayCustomers[0] = customr1;
            arrayCustomers[1] = customr2;
            arrayCustomers[2] = customr3;

            Dictionary<int, Customer1> dict = arrayCustomers.ToDictionary(cus => cus.ID, cus => cus);
            foreach(var k in dict)
            {
                Console.WriteLine(k.Value.Name);
            }
            Console.WriteLine();

            Dictionary<int, Customer1> dict1 = arrayCustomers.ToDictionary(cus => cus.ID);  // value na dileo oi ta automatic niye ney
            foreach (var k in dict1)
            {
                Console.WriteLine(k.Value.Name);
            }
            Console.WriteLine();

            List<Customer1> list = new List<Customer1>();
            list.Add(customr1);
            list.Add(customr2);
            list.Add(customr3);
            Dictionary<int, Customer1> dictLList = list.ToDictionary(cus => cus.ID, cus => cus);
            foreach (var k in dictLList)
            {
                Console.WriteLine(k.Value.Name);
            }
            Console.WriteLine();

            List<Customer1> list1 = new List<Customer1>();
            list1.Add(customr1);
            list1.Add(customr2);
            list1.Add(customr3);
            Dictionary<int, Customer1> dictLList1 = list1.ToDictionary(cus => cus.ID);      // value na dileo oi ta automatic niye ney
            foreach (var k in dictLList1)
            {
                Console.WriteLine(k.Value.Name);
            }

        }
    }
    public class Customer1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
