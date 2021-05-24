using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces
{
    class PhoneNumbers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            string str_new = ""; 
            if(n % 2 == 0)
            {
                for(int i = 0; i < str.Length; i++)
                {
                    if(i % 2 == 0 && i != 0)
                    {
                        str_new += "-";
                        str_new += str[i];
                    }
                    else
                    {
                        str_new += str[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (i % 2 == 0 && i != 0)
                    {
                        str_new += "-";
                        str_new += str[i];
                    }
                    else
                    {
                        str_new += str[i];
                    }
                }
                str_new = str_new.Remove(str_new.Length - 2, 1);
            }

            Console.WriteLine(str_new);
            //Console.ReadKey();
        }
    }
}
