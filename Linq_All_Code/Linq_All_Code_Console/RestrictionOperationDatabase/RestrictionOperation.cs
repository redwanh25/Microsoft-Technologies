using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.RestrictionOperationDatabase
{
    class RestrictionOperation
    {
        public static void Main(string[] args)
        {
            Linq_All_Code_DBEntities entities = new Linq_All_Code_DBEntities();
            IEnumerable<Department> departments = entities.Departments
                .Where(dept => dept.Name == "IT" || dept.Name == "HR");

            foreach (Department department in departments)
            {
                Console.WriteLine("Department Name = " + department.Name);
                foreach (Employee employee in department.Employees.Where(emp => emp.Gender == "Male"))
                {
                    Console.WriteLine("\tEmployee Name = " + employee.FirstName + " " + employee.LastName);
                }
                Console.WriteLine();
            }
        }
    }
}
