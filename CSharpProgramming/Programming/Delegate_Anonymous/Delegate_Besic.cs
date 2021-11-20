using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Delegate_Anonymous
{

    public delegate string Hello(int aa);

    class Delegate_Besic
    {
    //  private delegate string Hello(int aa);

        public static void Main(String[] args)
        {
            Delegate_Besic db = new Delegate_Besic();

            Hello hh = new Hello(db.print);     // aikhane method er nam argument hishe be dite hobe..
          //Hello hh = new Hello(db.pri);       // error hobe.
            string res = hh(420);
            Console.WriteLine(res);

        }
        //delegate string Hello(int aa);        delegate er khetre return type and parameter r jake point korbe tar
        public string print(int a)      //  return type and parameter same hote hobe. noile point korte parbe na.
        {
            string str = a.ToString();
            return str;
        }
        public void pri(int s)
        {
            Console.WriteLine("Redwan");
        }
    }
}
