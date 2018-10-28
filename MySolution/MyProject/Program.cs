using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("redwan");
            Program p = new Program();
            //    int[] problems = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();         // both are correct
            //    int[] problems = Console.ReadLine().Split().Select((string s) => int.Parse(s)).ToArray();    // lambda expression
            int[] problems = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();    // both are correct
            foreach (int i in problems)
            {
                Console.WriteLine(i);
            }
            string[] st = Console.ReadLine().Split(' ');
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
            int a = p.Red();
            Console.WriteLine("{0}", p.Red());
            Console.WriteLine(a);
            string str = Console.ReadLine(), str1 = Console.ReadLine();
            Console.WriteLine("{0} {1} {{2}}", str, str1);       // {2} print korte chaile {2} dile hobe na. {{2}} aita dite hobe...
            int a1 = int.Parse(Console.ReadLine());
            var rr = Convert.ToInt32(Console.ReadLine());       // space diye akta number diye input dile e program crush korbe.
            Console.WriteLine("{0} {1}", a1, rr);
            //    Console.ReadKey();
        }

        public int Red()
        {
            Red1();
            return 13;
        }
        public void Red1()
        {
            int a = 9;
            bool ck = (a == 9 ? true : false);
            Console.WriteLine("{0}", "what the");
            //    Console.WriteLine(ck);
            Console.WriteLine(a == 9 ? ck.ToString() : "redwan"); // ck.ToString() likhte hobe just ck likhle error dibe. mane dui ta type e same hote hobe
            Console.Write("what the  ");                          // hoy dui tai string na hoy dui tai bool, na hoy int ..   logic ? one type : two type
        }
    }
}
