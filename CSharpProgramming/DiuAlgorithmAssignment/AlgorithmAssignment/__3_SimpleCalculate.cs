using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class __3_SimpleCalculate
    {
        public static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split();
            string[] str2 = Console.ReadLine().Split();
            int i1 = int.Parse(str1[1]);
            double money1 = double.Parse(str1[2]);
            int i2 = int.Parse(str2[1]);
            double money2 = double.Parse(str2[2]);
            Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", (i1*money1) + (i2*money2));
        }
    }
}
