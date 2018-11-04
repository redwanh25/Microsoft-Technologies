using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Generics
{
    public class MainClass
    {
        private static void Main()
        {
            //bool Equal = Calculator.AreEqual(2, 2);
            bool Equal = CalculatorGen<string>.AreEqual("ab", "ab"); 
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)      // method generic type
        {
            return value1.Equals(value2);
        }
    }
    public class CalculatorGen<T>       // class generic type
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
