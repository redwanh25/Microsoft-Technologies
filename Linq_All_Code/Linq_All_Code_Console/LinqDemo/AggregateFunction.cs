using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    class AggregateFunction
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5 };
            int fact = arr.Aggregate((a, b) => a * b);      // (1)*1*2*3*4*5 = 120
            Console.WriteLine(fact);

            fact = arr.Aggregate(10, (a, b) => a * b);      // (10)*1*2*3*4*5 = 1200
            Console.WriteLine(fact);

            List<string> country = new List<string> { "india", "bangladesh", "usa" };
            string print = country.Aggregate((a, b) => a + ", " + b);
            Console.WriteLine(print);
            //deferred or lazy operation (Where, Select, Take, Skip)
            IEnumerable<string> MaxString = country.Where(l => l.Length == country.Max(c => c.Length));
            // output a "united kingdom" show korbe.

            // immediate or greedy operations (Count, Average, Min, Max, ToList)
            string MaxlengthString = country.Where(l => l.Length == country.Max(c => c.Length)).Max();
            int lengthBefore = country.Max(c => c.Length);
            string diff = country.Max();        // look at the output "usa" u > i > b

            country.Add("united kingdom");
            int lengthAfter = country.Max(c => c.Length);

            Console.WriteLine("# " + MaxlengthString + " " + lengthBefore + " " + lengthAfter + " " + diff);
            foreach(string str in MaxString)
            {
                Console.WriteLine("* " + str);
            }

            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int smallestNumber = Numbers.Min();
            int smallestEvenNumber = Numbers.Where(n => n % 2 == 0).Min();

            int largestNumber = Numbers.Max();
            int largestEvenNumber = Numbers.Where(n => n % 2 == 0).Max();

            int sumOfAllNumbers = Numbers.Sum();
            int sumOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Sum();

            int countOfAllNumbers = Numbers.Count();
            int countOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Count();

            double averageOfAllNumbers = Numbers.Average();
            double averageOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Average();

            Console.WriteLine("Smallest Number = " + smallestNumber);
            Console.WriteLine("Smallest Even Number = " + smallestEvenNumber);

            Console.WriteLine("Largest Number = " + largestNumber);
            Console.WriteLine("Largest Even Number = " + largestEvenNumber);

            Console.WriteLine("Sum of All Numbers = " + sumOfAllNumbers);
            Console.WriteLine("Sum of All Even Numbers = " + sumOfAllEvenNumbers);

            Console.WriteLine("Count of All Numbers = " + countOfAllNumbers);
            Console.WriteLine("Count of All Even Numbers = " + countOfAllEvenNumbers);

            Console.WriteLine("Average of All Numbers = " + averageOfAllNumbers);
            Console.WriteLine("Average of All Even Numbers = " + averageOfAllEvenNumbers);
        }
    }

    /// <Summery>
    /// deferred or lazy operation (Where, Select, Take, Skip)
    /// IEnumerable<string> MaxString = country.Where(l => l.Length == country.Max(c => c.Length)); ai statement hosse lazy
    /// mane kono kisu list a age add korle or pore add korle she thik e calculate kore nibe. ai khane r oi logic ta khatbe na j code
    /// line by line kaj kore. but, obosshoi list a add korle print korar age add korte hobe. cs, print korar pore add kore lav ki
    /// print to kore e dise.
    /// 
    /// immediate or greedy operations (Count, Average, Min, Max, ToList)
    /// string MaxlengthString = country.Where(l => l.Length == country.Max(c => c.Length)).Max(); ai statement ta hosse greedy.
    /// mane ai khane oi logic ta khatbe j code line by line kaj kore. oi statement paoyar pore kono kisu list a add korle she r oi ta calculate
    /// korbe na. 
    /// </Summery>

}
