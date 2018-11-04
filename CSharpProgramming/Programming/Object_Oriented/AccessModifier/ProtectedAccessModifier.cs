using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.AccessModifier
{
    //                              Types Vs Type Members
    //In this example Customer is the Type and fields, properties and method are Type members.
    //So, in general classes, structs, enums, interfaces, delegates are called as types
    //and fields, properties, constructors, methods etc.. that normally reside in a type are called  as type members.

    internal class Customer     // class er access modifier internal or public or default hote parbe.
                                // private/protected/protected internal dile error dibe.
    {
        protected int id;       // protected member k oi class er moddhe access kora jabe. and oi class k j inherit korbe
                                // tar object create kore access kora jabe. but, oi class er moddhe abr Customer er object
                                // toiri korle kintu hobe na. be careful.

        private int num;        // private access modifier k shudhu oi class er moddhe e access kora jabe.
        public int roll;        // public access modifier k jekono jayga theke access kora jabe.
        int number;             // Type members er age kono access modifier deoya na thakle oita default vabe private hoye jay.
    }

    class Redwan : Customer
    {
        public void Method()
        {
            Customer cus = new Customer();
            //cus.id = 5;   // we can not write this line. error dibe.

            Redwan red = new Redwan();
            red.id = 5;
            Console.WriteLine(red.id);
            base.id = 10;
            id = 6;
            this.id = 7;

        }
    }
    class ProtectedAccessModifier       // Type er age kono access modifier deoya na thakle default vabe oita internal thake.
    {
        public void Method()
        {
            Customer cus = new Customer();
            //cus.id = 5;       // we can not write this line
            //cus.number = 10;  // we can not write this line
        }
    }
}
