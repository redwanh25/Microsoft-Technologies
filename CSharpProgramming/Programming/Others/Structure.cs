using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Others
{
    public struct Struc
    {
        private int i;
        private string str;

        public string Name
        {
            get { return str; }
            set { str = value; }
        }

        //public int Id
        //{
        //    get { return i; }
        //    set { i = value; }
        //}

        public int Id { get; set; }

        public Struc(int i, string str, int Id)         // ami jei koyekta instance variable decleare korbo shob gulo constructor er moddhe
        {                                               // dite hobe. noile error hobe. ai "Id" o. cs, ai kahane ami just get; set; likhsi.
            this.str = str;
            this.i = i;
            this.Id = Id;
        }

        public void print()
        {
            Console.WriteLine(this.i + " " + this.str + " " + this.Id);
        }


    }

    public class Structure
    {
        public static void Main(string[] args)
        {
            Struc st = new Struc(2, "red", 171);
            Struc st1 = new Struc();      // ai ta difference struc and class er moddhe. ai constructor ta toiri kora nai kintu struct a built in niye ney.
                                          // kintu class er khetre emon ta na. jodi constructor koiri na kori taile  Struc st1 = new Struc(); likha jabe.
                                          // r jodi akta constructor toiri kore feli and oi tar parameter dei taile r Struc st1 = new Struc(); likhe hobe na.
                                          // tokhon error dibe.
            st.print();     // 2 red 171

            st1.print();    // 0  0

            st1.Id = 172;
            st1.Name = "keya";
            st1.print();    // 0 keya 172
        }
    }
}
