using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    class SelectMany_Example
    {
        public static void Main(string[] args)
        {
            IEnumerable<string> allSubjects = Student.GetAllStudetns().SelectMany(s => s.Subjects);
            foreach (string subject in allSubjects)
            {
                Console.WriteLine(subject);
            }

            Console.WriteLine("=========================");

            IEnumerable<string> allSubjects1 = from student in Student.GetAllStudetns()
                                             from subject in student.Subjects
                                             select subject;

            foreach (string subject in allSubjects1)
            {
                Console.WriteLine(subject);
            }

            Console.WriteLine("=========================");

            string[] stringArray = { "ABCD", "0123" };
            IEnumerable<char> result1 = stringArray.SelectMany(s => s);
            foreach (char c in result1)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("=========================");

            string[] stringArray0 = { "ABCD", "0123" };
            IEnumerable<char> result0 = stringArray.SelectMany(s => s).Where(x => x.Equals('0'));
            foreach (char c in result0)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("=========================");

            string[] stringArray1 = { "ABCD", "0123" };
            IEnumerable<char> result2 = from s in stringArray1 from c in s select c;
            foreach (char c in result2)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("=========================");

            IEnumerable<string> allSubjects2 = Student.GetAllStudetns().SelectMany(s => s.Subjects).Distinct();
            foreach (string subject in allSubjects2)
            {
                Console.WriteLine(subject);
            }

            Console.WriteLine("=========================");

            IEnumerable<string> allSubjects3 = (from student in Student.GetAllStudetns()
                                               from subject in student.Subjects
                                               select subject).Distinct();

            foreach (string subject in allSubjects3)
            {
                Console.WriteLine(subject);
            }

            Console.WriteLine("=========================");

            var result = Student.GetAllStudetns().SelectMany(s => s.Subjects, (student, subject) =>
                                                new { StudentName = student.Name, Subject = subject });
            foreach (var v in result)
            {
                Console.WriteLine(v.StudentName + " - " + v.Subject);
            }

            Console.WriteLine("=========================");

            var result3 = from student in Student.GetAllStudetns()
                         from subject in student.Subjects
                         select new { StudentName = student.Name, Subject = subject };

            foreach (var v in result3)
            {
                Console.WriteLine(v.StudentName + " - " + v.Subject);
            }

            Console.WriteLine("=========================");

            var result4 = Student.GetAllStudetns().Select(stu => new { StudentName = stu.Name + stu.Gender, GenderName = stu.Gender });
            foreach (var v in result4)
            {
                Console.WriteLine(v.StudentName + " - " + v.GenderName);
            }

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }

        public static List<Student> GetAllStudetns()
        {
            List<Student> listStudents = new List<Student>
            {
                new Student
                {
                    Name = "Tom",
                    Gender = "Male",
                    Subjects = new List<string> { "ASP.NET", "C#" }
                },
                new Student
                {
                    Name = "Mike",
                    Gender = "Male",
                    Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
                },
                new Student
                {
                    Name = "Pam",
                    Gender = "Female",
                    Subjects = new List<string> { "WCF", "SQL Server", "C#" }
                },
                new Student
                {
                    Name = "Mary",
                    Gender = "Female",
                    Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
                },
            };

            return listStudents;
        }
    }
}
