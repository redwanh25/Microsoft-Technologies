using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Constructor
{
    class StaticConstructor
    {
        private int a;
        private string str;
        private long ln;
        private double lf;
        public static float f;
        private static double dl;

        public StaticConstructor(int a, string str, long ln, double lf)
        {
            this.a = a;
            this.str = str;
            this.ln = ln;
            this.lf = lf;
        }

        static StaticConstructor()  // a static constructor must be parameter less. parameter dile hobe na. 
        {                           // static constructor er kono object toiri kora jay na. automatic call hoy.
            f = 5.6f;            // by default aita double a thake. tai aita k float a conver korte hole 5.6f
                                 //  f = (float) 5.6;     // likhte hobe. na hole (float) 5.6 likhe type casting kore dite hobe.
                                 // static theke non static k daka jay na. ai jonno "f" k static hote hobe.
        }

        public static void Main()
        {
            //   StaticConstructor sc = new StaticConstructor();   ai vabe StaticConstructor er object toiri kora jabe na. 
            //   just value assign kora jabe.
            StaticConstructor sc = new StaticConstructor(1, "redwan", 2, 4.5);
            Console.WriteLine("{0} {1} {2} {3}", sc.a, sc.str, sc.ln, sc.lf);

            Console.WriteLine(f);   // aitai holo static constructor er shubidha.
            f = 1.2f;
            dl = 23.99;
            Console.WriteLine(f + " " + dl);
        }
    }

    class abc
    {
        public static void abcd()
        {
            StaticConstructor.f = 85;
         //   f = 45.5;                     // error hobe.
        }
    }
}
