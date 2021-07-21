using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class User
    {
        static User()
        {
            Console.WriteLine("I am Static Constructor");
        }
        public User()
        {
            Console.WriteLine("I am Default Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            User user1 = new User();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
