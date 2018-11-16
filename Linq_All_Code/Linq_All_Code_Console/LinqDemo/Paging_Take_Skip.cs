using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    class Paging_Take_Skip
    {
        public static void Main()
        {
            // Reverse_OrderBy_ThenBy_OrderByDescending_ThenByDescending ai class er moddhe ase Student1 class
            IEnumerable<Student1> students = Student1.GetAllStudents();

            do
            {
                Console.WriteLine("Please enter Page Number - 1, 2 or 3");
                int pageNumber = 0;

                if (int.TryParse(Console.ReadLine(), out pageNumber))
                {
                    if (pageNumber >= 1 && pageNumber <= 3)
                    {
                        int pageSize = 2;
                        IEnumerable<Student1> result = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);

                        Console.WriteLine();
                        Console.WriteLine("Displaying Page " + pageNumber);
                        foreach (Student1 student in result)
                        {
                            Console.WriteLine(student.StudentID + "\t" + student.Name + "\t" + student.TotalMarks);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Page number must be an integer between 1 and 3");
                    }
                }
                else
                {
                    Console.WriteLine("Page number must be an integer between 1 and 4");
                }
            } while (1 == 1);
        }
    }
}
