using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Abstract_Interface
{
// part 1...

    abstract class A
    {           // class a at least akta method jodi abstract thake taile e
        public void swim()
        {   // amder class er age abstract likhte hobe.

        }
        public abstract void run();
    }

    abstract class B
    {           // class a jodi akta method o abstract na thake taile o abstract likha jabe.
        public B()
        {
            // abstract class a constructor toiri kora jay
        }
        public void swim()
        {

        }
        public int run(int a)
        {
            int b = a;
            return b;
        }
    }
    //----------------------------------------

    // part 2...

    abstract class C
    {

        public abstract void swim();
        public void red()
        {
            Console.WriteLine("obj3");
        }
    }

    class D : C
    {
        public override void swim()
        {
            Console.WriteLine("obj1 + obj2");
        }
        public void ride()
        {
            Console.WriteLine("obj3 downcast");
        }
    }
    //-----------------------------------------

    class E
    {
        public E()
        {
            Console.WriteLine("obj6 + obj7");
        }
        public E(int x)
        {
            Console.WriteLine("***");
        }
    }

    class F : E
    {
                                    //  akshathe duita base keyword use kora jay na.
    // 	public F() : base(1)	    // aita default vabe likha thake na. argument shoho nije call korte hoy.
        public F() : base()         // default vabe likha thake. na likhleo problem nai.	page: 169
        {
            Console.WriteLine("obj6 + obj7 : R");
        }
    }

    public class Abstract1
    {

        public static void Main(String[] args)
        {
            //	A obj = new A();	// we can't create a object for abstract class
            // 	B obj = new B();	// we can't create a object for abstract class
            //--------------------
		
		    D obj1 = new D();
            obj1.swim();
		    obj1.ride();
		
		    C obj2 = new D();    // we can create a object for subclass with abstract superclass type.
            obj2.swim();		 
	    //  C obj2 = new C();    // but we can not create a object for abstract superclass.
		
		    C obj3 = new D();
            //	obj3.ride();		// we can not write this line. because obj3 reference er type hosse C and
            // amra jei method k call koresi shei method ta superclass er kono method
            // k override kore ni. jodi override na kore taile amader downcasting kore call korte hobe. override 
            // na korle downcasting sara amra shudu superclass er method ke call korte parbo na. r override korle
            // amra je subclass er object toiri korbo tar method k call kora jabe.

            obj3.red();
		    ((D) obj3).ride();

            //------------------------

            //	F obj6 = new F();
            E obj7 = new F();
        }
    }

}
