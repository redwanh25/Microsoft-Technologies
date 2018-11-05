using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All
{
    class OptionalParamerers
    {
        public static void Main(string[] args)
        {
            AddNumbers(10, 20, null);
            AddNumbers(10, 20);
            //AddNumbers(10);
            AddNumbers(10, 20, new int[] {10, 20});
            // AddNumbers(10, new int[] { 10, 20 }, 20);
            AddNumbers(secondNumber: 30, firstNumber: 20);      // amra jodi parameter ultapalta kori taile amader aivabe bole dite hobe.
        }

        // public static void AddNumbers(int firstNumber, int[] arr, int secondNumber)  // emon ta likha jabe.
        // public static void AddNumbers(int firstNumber, int[] arr = null, int secondNumber)  // emon ta likha jabe na.
        // cause optional parameter always last a dite hobe.
        // public static void AddNumbers(int firstNumber, int secondNumber, int[] arr = null)   // emon ta likha jabe.
        // public static void AddNumbers(int firstNumber, int secondNumber = 10, int[] arr = null) // emon ta likha jabe.
        // public static void AddNumbers(int firstNumber, int secondNumber = 10, [Optional] int[] arr) // emon ta likha jabe na.
        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] arr)
        {
            Console.WriteLine("firstNumber: {0}, secondNumber: {1}", firstNumber, secondNumber);
            int result = firstNumber + secondNumber;
            if(arr != null) {
                foreach (int i in arr)
                {
                    result += i;
                }
            }

            Console.WriteLine("Total = " + result.ToString());
        }
    }
}
