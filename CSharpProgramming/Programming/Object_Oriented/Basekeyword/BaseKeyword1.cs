using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Basekeyword
{
    class Dog
    {
        public int leg;
        public Dog(int leg)
        {
            this.leg = leg;
        }
        public void Eat(String str)
        {
            Console.WriteLine(str);
        }
    }

    class DeshiDog : Dog
    {
        public DeshiDog(int leg) : base(leg)
        {

        }
        public void Can()
        {
            base.Eat("egg");        // base class er method k call
        }
    }

    class BideshiDog : Dog
    {
        public BideshiDog(int leg) : base(leg)
        {

        }

        public void Can()
        {
            base.leg = 5;       // base class er field a value assign
        }
    }

    class BaseKeyword1
    {
        public static void Main (String[] args)
        {
            BideshiDog bd = new BideshiDog(4);
            bd.Can();
            Console.WriteLine(bd.leg);
            bd.Eat("grass");


        }
    }
}
