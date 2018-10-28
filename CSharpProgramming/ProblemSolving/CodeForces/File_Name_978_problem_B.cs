using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces
{
    class File_Name_978_problem_B
    {
        public static void Main(string[] args)
        {
            string st = Console.ReadLine();
            string str = Console.ReadLine();
            string s = "xxx";
            int cnt = 0;
            for(int i = 0; i < str.Length-2; i++)
            {
                if(str.Substring(i, 3).Equals(s))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
