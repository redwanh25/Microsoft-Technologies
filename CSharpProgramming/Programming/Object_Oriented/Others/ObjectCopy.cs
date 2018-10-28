using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Others
{
    class ObjectCopy
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static void Main(string[] args)
        {
            ObjectCopy obj = new ObjectCopy();
            obj.Id = 12;
            obj.Name = "redwan";
            Console.WriteLine("{0} {1}", obj.Id, obj.Name);

            ObjectCopy obj1 = obj;
            obj1.Name = "nipu";
            Console.WriteLine("{0} {1}", obj.Name, obj1.Name);

            int[] arr = { 1, 2, 3 };

            foreach(Object i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (object i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
