using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.GetSet
{
    class GetterSetter1
    {
        private int a;
        private int b;
        private String str, str1;

        public String StrRed{ get; set; }

    //  public int Name { get ; }
    //  public int Name1 { get; set; }      // aita r nicher oita same

        public int Name1
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public static void Main(String[] str)
        {
            GetterSetter1 gs = new GetterSetter1();
            gs.Name1 = 56;
            gs.b = 12;
            Console.WriteLine(gs.a + " " + gs.Name1);
            gs.str = "redwan";
            gs.str1 = "hossain";
            Console.WriteLine("{0} {1}", gs.str, gs.str1);
        }
    }
}
