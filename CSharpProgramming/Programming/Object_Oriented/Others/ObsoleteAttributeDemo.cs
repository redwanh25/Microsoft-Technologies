using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Others
{

    class ObsoleteAttributeDemo
    {
        private static void Main()
        {
            int sum = Calculator.Add(10, 15);       // mane amake force kora hosse "Add(List<int> Numbers)" method ta use korar jonno.
            Console.WriteLine(sum);
            int sum1 = Calculator.Add(new List<int>() { 10, 20, 30 });     // mane amake force kora hosse ai method ta use korar jonno.
            Console.WriteLine(sum1);
        }
    }

    public class Calculator
    {
          [Obsolete("Use Add(List<int> Numbers) Method")]             // default vabe false thake. false mane just warning dibe.
        //  [Obsolete("Use Add(List<int> Numbers) Method", true)]       // true dile error dibe. 13 no line a error dibe.
        //  [ObsoleteAttribute("Use Add(List<int> Numbers) Method")]    //aitao hobe.
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach (int Number in Numbers)
            {
                Sum = Sum + Number;
            }
            return Sum;
        }
    }
}
