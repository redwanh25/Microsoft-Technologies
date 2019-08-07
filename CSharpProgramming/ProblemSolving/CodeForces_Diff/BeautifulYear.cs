using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces_Diff
{
    class BeautifulYear
    {
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            bool check = true;

            while (check == true)
            {
                number++;
                string str = number.ToString();
                char[] ch = str.ToCharArray();

                var unique = ch.GroupBy(x => x).Where(per => per.Count() > 1).Select(y => y.Key).ToArray();

                if (unique.Length == 0)
                {
                    Console.WriteLine(str);
                    check = false;
                }
            }
            
        }
    }
}
