using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class _16_AbovetheSecundaryDiagonal
    {
        public static void Main(string[] args)
        {
            Double sum = 0;
            string s = Console.ReadLine();
            Double[][] arr = new Double[12][];
            for (int i = 0; i < 12; i++)
            {
                arr[i] = new Double[12];
                for (int j = 0; j < 12; j++)
                {
                    arr[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            for(int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 11-i; j++)
                {
                    sum += arr[i][j];
                }
                    
            }
            Console.WriteLine("{0:F1}", s.Equals("S") ? sum : sum/66);
        }
    }
}
