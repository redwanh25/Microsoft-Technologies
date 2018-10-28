using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.ObjectCopy
{
    class Obje
    {
        public int i, j;
    }

    class Difference
    {
        public static void diff(Obje obj)
        {
            obj.i = 10;
            obj.j = 20;
            Console.WriteLine(obj.i + " " + obj.j);
        }

        public static void Main(String[] arg)
        {
            Obje obj1 = new Obje();
            obj1.i = 5;
            obj1.j = 6;
            Console.WriteLine(obj1.i + " " + obj1.j);

            diff(obj1);                                         // difference
            Console.WriteLine(obj1.i + " " + obj1.j);

            //diff(new Obje());                                 // difference
            //Console.WriteLine(obj1.i + " " + obj1.j);
        }
    }
}
