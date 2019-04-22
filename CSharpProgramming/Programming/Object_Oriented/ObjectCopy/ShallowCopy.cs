using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.ObjectCopy
{
    class Obj
    {
        public int i, j;
    }

    class ShallowCopy
    {
        public static void Main(String[] arg)
        {
            Obj obj1 = new Obj();
            obj1.i = 5;
            obj1.j = 6;
            Console.WriteLine(obj1.i + " " + obj1.j);

            Obj obj2 = new Obj(); // dui tai same kahini. but, aitate shudhu shudhu akta object turi kore jayga khabe.
            obj2 = obj1;          // hashcode dui object er e same hobe. mane dui tar address e same hobe.
          //  Obj obj2 = obj1;

            obj1.i = 10;
            Console.WriteLine(obj1.i + " " + obj1.j);
            Console.WriteLine(obj2.i + " " + obj2.j);

            //  output
            //  5 6
            //  10 6
            //  10 6
        }
    }
}
