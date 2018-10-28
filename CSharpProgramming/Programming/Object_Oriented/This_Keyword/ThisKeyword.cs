using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.This_Keyword
{
    /// this		--> 	 (instance k use and method k call korar jonno)
    /// this() 		-->		 (just constructor k call korar jonno)

    class Tast
    {
        private int a;
        private int x;

        public Tast(int a, int b, int c) : this(a, b)       // Constructor call must be the first statement in a constructor
        {            
            //this.a = a;
            Console.WriteLine(this.a);
        }
        public Tast(int a, int b) : this(a)
        {
            this.a += 15;
            Console.WriteLine(this.a);
            this.a = a;
            Console.WriteLine(this.a);
        }
        public Tast(int a)
        {
            Console.WriteLine(a);
            this.x = 5;
            x = 5;      // x er age by default "this" keyword ta ase. mane this.x = 5
        }
        public void aaa()
        {
            Console.WriteLine("Redwan");
            bbb();          // amra jokhon same class a akta method theke onno akta method k call kori tokhon tar age
                            // compiler by default "this" keyword boshay dey.
            this.bbb();     // bbb() same as this.bbb();
        }

        // be careful, static method er vitore "this" keyword use kora jay na. 

        public void bbb()
        {
            Console.WriteLine("hossain");
        }
    }

    class Foo
    {
        public void useBarMethod()
        {
            Bar theBar = new Bar();
            theBar.barMethod(this);     // "this" mane ai class er e object k bujay. 	
                                        // argument hosse this. r ai "this" mane hosse "new Foo()"
        }
        public String getName()
        {
            return "Foo";
        }
    }

    class Bar
    {
        public void barMethod(Foo obj)
        {   // Foo obj = new Foo();
            Console.WriteLine(obj.getName());
        }
    }

    public class ThisKeyword
    {

        public static void Main(String[] args)
        {
            Tast t = new Tast(2, 3, 4);
            t.aaa();
            Foo f = new Foo();
            f.useBarMethod();
        }
    }
}
