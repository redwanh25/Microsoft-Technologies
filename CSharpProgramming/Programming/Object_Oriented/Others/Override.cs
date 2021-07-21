using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Others
{
    class Dog
    {
        public virtual void swirl()
        {
            Console.WriteLine("Dog");
        }
    }

    class DeshiDog : Dog
    {

        public override void swirl()
        {
            Console.WriteLine("DeshiDog");
        }
    }

    class BideshiDog : Dog
    {

        public void swirl()
        {
            Console.WriteLine("BideshiDog");
        }
    }

    public class Override
    {
        public static void Main(String[] args)
        {
            Dog dog = new Dog();
            Dog deshiDog = new DeshiDog();
            Dog bideshiDog = new BideshiDog();

            dog.swirl();
            deshiDog.swirl();
            bideshiDog.swirl();

        }
    }
}
