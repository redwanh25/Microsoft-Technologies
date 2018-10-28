using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Polymorphism
{
    class Liquid
    {
        public virtual void swirl()
        {
            Console.WriteLine("Liquid");
        }
    }

    class Coffee : Liquid
    {
        public override void swirl()
        {
            Console.WriteLine("Coffee");
        }
    }

    class Milk : Liquid
    {
        public override void swirl()
        {
            Console.WriteLine("Milk");
        }
    }

    class CoffeeCup
    {
        private Liquid innerLiquid;
        public void addLiquid(Liquid liq)
        {
            innerLiquid = liq;
            innerLiquid.swirl();
            //	liq.swirl();
        }
    }

    public class UpCasting
    {

        public static void Main(String[] args)
        {
            Liquid liquid = new Liquid();
            Coffee coffee = new Coffee();
            Milk milk = new Milk();

            CoffeeCup cup = new CoffeeCup();

            cup.addLiquid(liquid);
            cup.addLiquid(coffee);
            cup.addLiquid(milk);

        }
    }
}

/* 1. subclass jodi baseclass er method k Override na kore taile method call korar shomoy
 * 	  shudhu matro baseclass er method ke e call kora jay. tobe "Downcasting" kore ai problem
 * 	  er solution kora jay.
 * 
 * 2. subclass jodi baseclass er method Override kore taile run time a subclass er method
 *    tai call hobe.
 * 
 */
