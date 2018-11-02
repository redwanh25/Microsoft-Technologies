using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.ExceptionHandling
{
    public class ExceptionHandlingAbuse
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Please enter Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Please enter Denominator");
                //Convert.ToInt32() can throw FormatException, if the entered value
                //cannot be converted to integer. So use int.TryParse() instead
                int Denominator = Convert.ToInt32(Console.ReadLine());


                int Result = Numerator / Denominator;


                Console.WriteLine("Result = {0}", Result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Only numbers between {0} & {1} are allowed",
                    Int32.MinValue, Int32.MaxValue);


            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch (Exception)       // amra chaile variable name na o dite pari..
            {
                Console.WriteLine("hahahahah...");
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
