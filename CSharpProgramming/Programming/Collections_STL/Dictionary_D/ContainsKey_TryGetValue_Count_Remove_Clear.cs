using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.Dictionary_D
{
    class ContainsKey_TryGetValue_Count_Remove_Clear
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
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customr1.ID, customr1);
            dictionaryCustomers.Add(customr2.ID, customr2);
            dictionaryCustomers.Add(customr3.ID, customr3);

            // If you are not sure if a key is present or not, you can use 
            // TryGetValue() method to get the value from a dictionary.
            Customer customer999;
            if (dictionaryCustomers.TryGetValue(999, out customer999))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer999.ID, customer999.Name, customer999.Salary);
            }
            else
            {
                Console.WriteLine("Customer with Key = 999 is not found in the dictionary");
            }

            if (dictionaryCustomers.ContainsKey(101))
            {
                Customer cust = dictionaryCustomers[101];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("Key does not exist in the dictionary");
            }
            Console.WriteLine(dictionaryCustomers.Count);
            Console.WriteLine(dictionaryCustomers.Count());
            Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary >= 5500));

            dictionaryCustomers.Remove(101);
            Console.WriteLine(dictionaryCustomers.Count);
            foreach (var k in dictionaryCustomers)
            {
                Console.WriteLine(k.Value.Name);
            }
            Console.WriteLine();

            dictionaryCustomers.Clear();
            Console.WriteLine(dictionaryCustomers.Count);
        }

    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
