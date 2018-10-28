using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All.Array2D
{
    class Char1D
    {
        public static void Main(String[] arg)
        {
            //char[] ch = new char[6];
            //for(int i = 0; i < ch.Length; i++)
            //{
            //    ch[i] = Console.ReadKey().KeyChar;
            //}

            String str = Console.ReadLine();
            char[] ch = new char[str.Length];

            for(int i = 0; i < str.Length; i++)
            {
                ch[i] = str[i];
            }

            foreach(char i in ch)
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
    }
}
