using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    class Reverse_OrderBy_ThenBy_OrderByDescending_ThenByDescending
    {
        public static void Main(string[] args)
        {
            //List<Student1> result = Student1.GetAllStudents().OrderBy(s => s.Name).ToList();
            //IOrderedEnumerable<Student1> result = Student1.GetAllStudents().OrderBy(s => s.Name);

            IEnumerable<Student1> result = Student1.GetAllStudents().OrderBy(s => s.Name);
            foreach (Student1 student in result)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("=========================1");

            IEnumerable<Student1> result1 = from student in Student1.GetAllStudents() orderby student.Name
                                          select student;

            foreach (Student1 student in result1)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("=========================2");

            IEnumerable<Student1> result2 = Student1.GetAllStudents().OrderByDescending(s => s.Name);
            foreach (Student1 student in result2)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("=========================3");

            IEnumerable<Student1> result3 = from student in Student1.GetAllStudents() orderby student.Name descending
                                          select student;

            foreach (Student1 student in result3)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("=========================4");

            IEnumerable<Student1> result4 = Student1.GetAllStudents().OrderBy(s => s.TotalMarks).ThenBy(s => s.Name)
                                            .ThenByDescending(s => s.StudentID);
            foreach (Student1 student in result4)
            {
                Console.WriteLine(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
            }

            Console.WriteLine("=========================5");

            IEnumerable<Student1> result5 = from student in Student1.GetAllStudents()
                                            orderby student.TotalMarks, student.Name, student.StudentID descending
                                            select student;
            foreach (Student1 student in result5)
            {
                Console.WriteLine(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
            }

            Console.WriteLine("=========================6");

            IEnumerable<Student1> students = Student1.GetAllStudents();

            Console.WriteLine("Before calling Reverse");
            foreach (Student1 s in students)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
            }

            Console.WriteLine();
            IEnumerable<Student1> result6 = students.Reverse();

            Console.WriteLine("After calling Reverse");
            foreach (Student1 s in result)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
            }
        }   
}
    public class Student1
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student1> GetAllStudents()
        {
            List<Student1> listStudents = new List<Student1>
            {
                new Student1
                {
                    StudentID= 101,
                    Name = "Tom",
                    TotalMarks = 800
                },
                new Student1
                {
                    StudentID= 102,
                    Name = "Mary",
                    TotalMarks = 900
                },
                new Student1
                {
                    StudentID= 103,
                    Name = "Pam",
                    TotalMarks = 800
                },
                new Student1
                {
                    StudentID= 104,
                    Name = "John",
                    TotalMarks = 800
                },
                new Student1
                {
                    StudentID= 105,
                    Name = "John",
                    TotalMarks = 800
                },
            };

            return listStudents;
        }
    }
}
