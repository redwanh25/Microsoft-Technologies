using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Destructor
{
    class Destructor1
    {
        private long a;
        private String str;

        public Destructor1(long a, String str)
        {
            this.a = a;
            this.str = str;
        }

        ~ Destructor1()         // destructor parameter hishebe kisu ney na. constructor ney
        {
            Console.WriteLine("this is a Destructor");      // jokhon object ta destruct hoye jabe tokhon ai 
                                                            // destructor ta automatic call hobe. er age hobe na. 
        }

        public static void Main(String[] args)
        {
            //Read line, and split it by whitespace into an array of strings
            string[] tokens = Console.ReadLine().Split();

            //Parse element 0
            //   long a = Convert.ToInt64(tokens[0]);
            long a = long.Parse(tokens[0]);

            ////Parse element 1
            //int b = int.Parse(tokens[1]);

            Destructor1 des = new Destructor1(a, tokens[1]);
            Console.WriteLine(des.a);
            Console.WriteLine(des.str);

        //    Console.ReadKey();
        }
    }
}
