using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Code_Console.LinqDemo
{
    public class ExtensionMethod
    {
        public static void Main(string[] args)
        {
            string strName = "redwan";
            string result = strName.ChangeFirstLetterCase();        // extension method korte hole
            string result1 = StringHelper.ChangeFirstLetterCase(strName);

            Console.WriteLine(result + " " + result1);

            List<int> number = new List<int> { 1, 2, 3, 4, 5 };
            IEnumerable<int> it = number.Where(n => n % 2 == 0);
            foreach(int i in it)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            List<int> number1 = new List<int>() { 1, 2, 3, 4, 5 };
            IEnumerable<int> it1 = Enumerable.Where(number1, n => n % 2 == 1);
            foreach (int i in it1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }

    public static class StringHelper        // ai class k static korte hobe.
    {
        public static string ChangeFirstLetterCase(this string inputString)     // parameter er age this dite hobe.
        {                                           // and "this string inputString" ai ta first paramert hobe hobe.
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }

            return inputString;
        }

    }
}
