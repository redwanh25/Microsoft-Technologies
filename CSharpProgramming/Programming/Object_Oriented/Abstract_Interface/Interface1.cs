using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Abstract_Interface
{
    // interface er kono object toiri kora jay na but Type hishe use kora jay.
    // abstract class er kono object koiri kora jay na but Type hishebe use kora jay.
    // akta class er object toiri kora jay and Type hishebe o use kora jay.


    // interface a shob method e abstract hoy. constructor akta method er moto. but constructor er age
    // abstract likha jay na. ai jonno interface a kono constructor toiri kora jay na.

    interface G
    {
        //int a = 10;      //  javer moto c# a interface a fild declear kora jay na. 
        //public static sealed int b = 20;

        void boy();     // ai khane void boy() er age by default "public abstract" likha ase. amra likhle error hobe
        void girl();
    }

    interface I
    {
        void boy();
    }

    interface K
    {
        void girl();
    }

    // interface G te void boy() method a void boy() er age by default "public abstract" likha ase.
    // so, amra jokhon override korbo tokhon amader "public" ta must likhte hobe,

    class H : G
    {
        public void boy()   // aikhane "public" na dile error hobe. 
        {       
            Console.WriteLine("obj1 \"H\" boy");
        }

        public void girl()
        {
            Console.WriteLine("obj1 \"H\" girl");
        }
    }

    class O : H
    {

    }

    class J : G, I      // akta class onek gulu interface ke inherit korte pare.
    {	
        public void boy()
        {
            Console.WriteLine("obj2 \"J\" boy");
        }
        public void girl()
        {
            Console.WriteLine("obj2 \"J\" girl");
        }
    }

    interface L : K, I
    {
	    // something
    }

    abstract class M : L
    {
  //    public static int asd = 20;   // abstract class a field toiri kora jay
        public void boy()
        {   
        }

        public void girl()
        {  
        }

        public void red()
        {
            Console.WriteLine("redwan");
        }
    }

    class N : M, L, K, I, G     // ai line er mane N class , "M" ke inherit kore L K I G ke implements (inherit) kore.
    {                                
        public void boy()
        {
            Console.WriteLine("obj3 \"N\" boy");
        }
        public void girl()
        {
            Console.WriteLine("obj3 \"N\" girl");
        }
    }

    interface X
    {
        void redwan();
    }
    interface Y
    {
        void redwan();
    }
    class Z : X, Y
    {
        void X.redwan()         // public void X.redwan() ai rokom vabe shamne public dile hobe na. erron dibe
        {
            Console.WriteLine("redwan X");
        }
        void Y.redwan()         // ai take bola hoy explicit interface
        {
            Console.WriteLine("redwan Y");
        }

        public void redwan()
        {
            Console.WriteLine("redwan");
        }
    }

    public class Interface1
    {
        public static void Main(String[] args)
        {
            G obj1 = new H();
            obj1.boy();
            obj1.girl();

            J obj2 = new J();
            obj2.boy();
            obj2.girl();

            //	L obj3 = new N();
            //	N obj3 = new N();
            //	K obj3 = new N();
            G obj3 = new N();
            //	M obj3 = new N();
            //	obj3.red();

            obj3.boy();
            obj3.girl();

            X x = new Z();
            x.redwan();
            Y y = new Z();
            y.redwan();

            Z z = new Z();
            z.redwan();
            ((X) z).redwan();
            ((Y) z).redwan();
        }
    }

    // akta class just akta class ke ei inherit korte pare.	("extends")
    // akta class just akta abstract class ke ei inherit korte pare.	("extends")
    // akta class onek gulu interface k inherit korte pare. ("implements")
    // akta interface onek gulu interface k inherit korte pare. ("extends")
}
