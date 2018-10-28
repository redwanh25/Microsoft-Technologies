using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Inheritance
{

    class Dog
    {
        public int leg;

        public void eat(String str)
        {
            Console.WriteLine(str);
        }
    }

    class DeshiDog : Dog {  }

    class BideshiDog : Dog { }

    class Inheritance1
    {
        public static void Main(String[] arg)
        {
            Dog d = new Dog();
            d.eat("kisu khay na");

            DeshiDog dd = new DeshiDog();
            dd.eat("egg");

            BideshiDog bd = new BideshiDog();
            bd.eat("meat");
        }
    }
}
