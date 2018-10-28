using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class _19_Encryption
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(n-- != 0)
            {
                String str = Console.ReadLine();
                string str1 = "", str2 = "";
                for(int i = 0; i < str.Length; i++)
                {
                    if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
                    {
                        str1 += (char)(str[i]+3);
                    }
                    else
                    {
                        str1 += str[i];
                    }
                }
                List<char> list = new List<char>(str1);
                list.Reverse();
                str1 = new string(list.ToArray());

                for (int i = 0; i < str1.Length/2; i++)
                {
                    str2 += str1[i];
                }
                for (int i = str1.Length/2; i < str1.Length; i++)
                {
                    str2 += (char)(str1[i]-1);
                }
                Console.WriteLine(str2);
            }
        }
    }
}
