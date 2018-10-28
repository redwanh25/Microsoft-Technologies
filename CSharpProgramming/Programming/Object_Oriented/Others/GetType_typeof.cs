using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Others
{
    public class Point
    {
        public int X, Y;
    }
    public class What : Point
    {

    }

    class GetType_typeof
    {
        static void Main()
        {
            Point p = new What();
            Console.WriteLine(p.GetType().Name);  // What 
            Console.WriteLine(typeof(Point).Name);  // Point 
            Console.WriteLine(p.GetType() == typeof(Point)); // False 
            Console.WriteLine(p.X.GetType().Name);  // Int32
            Console.WriteLine(p.Y.GetType().FullName);  // System.Int32
        }
    }
}
