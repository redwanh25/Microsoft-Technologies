using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class _12_BhaskaraFormula
    {
        public static void Main(string[] args)
        {
            double[] str = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double a = str[0];
            double b = str[1];
            double c = str[2];
            Double z, R1, R2;
            
            z = Math.Pow(b, 2) - 4 * a * c;
            R1 = (-b + Math.Sqrt(z)) / (2 * a);
            R2 = (-b - Math.Sqrt(z)) / (2 * a);

            if (a != 0 && z >= 0)
            {
                Console.WriteLine("R1 = {0:F5}\nR2 = {1:F5}", R1, R2);
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
