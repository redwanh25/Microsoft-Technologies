using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class _11_Triangle_Types
    {
        public static void Main(string[] args)
        {
            double[] str = Console.ReadLine().Split().Select(double.Parse).ToArray();
            str = str.OrderByDescending(i => i).ToArray();

            double a = str[0];
            double b = str[1];
            double c = str[2];

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (a * a == b * b + c * c)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (a * a > b * b + c * c)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (a * a < b * b + c * c)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b &&  b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if ((b == c && a != b) || (c == a && b != c) || (a == b && c != a))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
