using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.URI
{
    class Encryption
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int x = 0; x < n; x++)
            {
                char[] ch = Console.ReadLine().ToCharArray();
                for(int i = 0; i < ch.Length; i++)
                {
                    if((ch[i] >= 'A' && ch[i] <= 'Z') || (ch[i] >= 'a' && ch[i] <= 'z'))
                    {
                        ch[i] = (char)(Convert.ToUInt16(ch[i]) + 3);
                    }              
                }
                Array.Reverse(ch);
                int half = ch.Length / 2;
                char[] ch1 = new char[half];
                char[] ch2 = new char[ch.Length-half];
                Array.Copy(ch, ch1, half);
                Array.Copy(ch, half, ch2, 0, ch.Length - half);

                for (int i = 0; i < ch2.Length; i++)
                {
                    ch2[i] = (char)(Convert.ToUInt16(ch2[i]) - 1);
                }
                string s = new string(ch1) + new string(ch2);

                Console.WriteLine(s);
            }

            //Console.ReadKey();
        }
    }
}
