using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.VJudge
{
    class A_Translation
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();
            str1 = str1.Reverse().ToString();
            Console.WriteLine("{0} {1}", str, str1);
            Console.WriteLine("{0}", str == str1 ? "YES" : "NO");

            Console.ReadKey();
        }
    }
}
