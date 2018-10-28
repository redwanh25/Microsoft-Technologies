using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.GetSet
{
    class GetterSetter4_Joss
    {

        private String str, str1;

        public int Name1 { get; set; }
        public String StrRed { get; set; }

        public static void Main(String[] str)
        {
            GetterSetter4_Joss gs = new GetterSetter4_Joss();
            gs.Name1 = 56;
            Console.WriteLine(gs.Name1);

            gs.str = "redwan";
            gs.str1 = "hossain";
            Console.WriteLine("{0} {1}", gs.str, gs.str1);

            gs.StrRed = "Ebrahim";
            Console.WriteLine(gs.StrRed);

            Console.WriteLine("{0} {1}", gs.str, gs.str1);
        }
    }
}
