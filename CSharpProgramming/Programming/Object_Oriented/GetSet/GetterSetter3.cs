using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.GetSet
{

    class TestEmployee1
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value + " JavaTpoint";
            }
        }
    }

    class GetterSetter3
    {
        public static void Main(string[] args)
        {
            TestEmployee1 e1 = new TestEmployee1();
            e1.Name = "Sonoo";
      //    e1.name = "Sonoo";      // aita kora jabe na. cs, field ta private kora ase. same class a use kora jeto.
            Console.WriteLine("Employee Name: " + e1.Name);
        }
    }
}
