using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Indexer
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();

            listEmployees.Add(new Employee() { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }

        // Use "this" keyword to create an indexer
        // This indexer takes employeeId as parameter
        // and returns employee name
        public string this[int employeeId]
        {
            // Just like properties indexers have get and set accessors
            get
            {
                return listEmployees.FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }

        public string this[string gender]
        {
            get { return listEmployees.Count(x => x.Gender == gender).ToString(); }
            set
            {
                foreach (Employee employee in listEmployees)
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Name of Employee with Id = 2: " + company[2]);
            Console.WriteLine("Name of Employee with Id = 5: " + company[5]);
            Console.WriteLine("Name of Employee with Id = 8: " + company[8]);

            Console.WriteLine("Changing names of employees with Id = 2,5,8");

            company[2] = "Employee 2 Name Changed";
            company[5] = "Employee 5 Name Changed";
            company[8] = "Employee 8 Name Changed";

            Console.WriteLine("Name of Employee with Id = 2: " + company[2]);
            Console.WriteLine("Name of Employee with Id = 5: " + company[5]);
            Console.WriteLine("Name of Employee with Id = 8: " + company[8]);

            Console.WriteLine();

            Console.WriteLine("Before changing the Gender of all male employees to Female");
            // Get accessor of string indexer is invoked to return the total
            // count of male employees
            Console.WriteLine("Total Employees with Gender = Male:" + company["Male"]);
            Console.WriteLine("Total Employees with Gender = Female:" + company["Female"]);

            // Set accessor of string indexer is invoked to change the gender
            // all "Male" employees to "Female"
            company["Male"] = "Female";

            Console.WriteLine("After changing the Gender of all male employees to Female");
            Console.WriteLine("Total Employees with Gender = Male:" + company["Male"]);
            Console.WriteLine("Total Employees with Gender = Female:" + company["Female"]);
        }
    }
}
