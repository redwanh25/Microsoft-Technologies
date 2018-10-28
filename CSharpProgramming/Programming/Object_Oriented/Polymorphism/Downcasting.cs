using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Polymorphism
{
    class Dog
    {
        public void swirl()
        {
            Console.WriteLine("Dog");
        }
    }

    class DeshiDog : Dog
    {

        public void swirl_1()
        {
        Console.WriteLine("DeshiDog");
        }
    }

    class BideshiDog : Dog
    {

        public void swirl_2()
        {
            Console.WriteLine("BideshiDog");
        }
    }

    public class DownCasting
    {

        public static void Main(String[] args)
        {
            Dog dog = new Dog();
            Dog deshiDog = new DeshiDog();
            Dog bideshiDog = new BideshiDog();

            dog.swirl();
            //deshiDog.swirl_1();   //i can not call this. because this method did not override.

            DeshiDog redwan = (DeshiDog)deshiDog;       // Downcasting
            redwan.swirl_1();

            ((BideshiDog)bideshiDog).swirl_2();     // Downcasting

        }
    }
}

/* 1. subclass jodi superclass er method k Override na kore taile method call korar shomoy
 * 	  shudhu matro superclass er method ke e call kora jay. tobe "Downcasting" kore ai problem
 * 	  er solution kora jay.
 * 
 * 2. subclass jodi superclass er method Override kore taile run time a subclass er method
 *    tai call hobe.
 * 
 */
