using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    public class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }
    }

    public class Lookup_Demo
    {
        public static void Main()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { Name = "Ben", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                new Employee() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                new Employee() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                new Employee() { Name = "Sara", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "Pam", JobTitle = "Developer", City = "London" }
            };

            // Group employees by JobTitle
            ILookup<string, Employee> employeesByJobTitle = listEmployees.ToLookup(x => x.JobTitle);
            //var employeesByJobTitle = listEmployees.ToLookup(x => x.JobTitle);

            Console.WriteLine("Employees Grouped By JobTitle");
            foreach (var kvp in employeesByJobTitle)
            {
                Console.WriteLine(kvp.Key);
                // Lookup employees by JobTitle
                foreach (var item in employeesByJobTitle[kvp.Key])
                {
                    Console.WriteLine("\t" + item.Name + "\t" + item.JobTitle + "\t" + item.City);
                }
            }

            Console.WriteLine(); Console.WriteLine();

            // Group employees by City
            var employeesByCity = listEmployees.ToLookup(x => x.City);

            Console.WriteLine("Employees Grouped By City");
            foreach (var kvp in employeesByCity)
            {
                Console.WriteLine(kvp.Key);
                // Lookup employees by City
                foreach (var item in employeesByCity[kvp.Key])
                {
                    Console.WriteLine("\t" + item.Name + "\t" + item.JobTitle + "\t" + item.City);
                }
            }
        }
    }
}
