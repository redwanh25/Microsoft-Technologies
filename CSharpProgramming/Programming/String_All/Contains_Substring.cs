using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class Contains_Substring
    {
        public static void Main(String[] args)
        {
            String[] str = Console.ReadLine().Split();
            String st1 = str[0];
            String st2 = str[1];

            for(int i = st2.Length-1, j = 0; i < st1.Length; j++, i++)
            {
                if(st2.Equals(st1.Substring(j, st2.Length)))
                {
                    Console.WriteLine("ase");
                }
            }
            Console.WriteLine(st1.Contains(st2) ? "ase" : "nai");
        }
    }
}
