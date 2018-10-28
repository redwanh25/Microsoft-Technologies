using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.AlgorithmAssignment
{
    class _20_LED
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                int res = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                        res += 2;
                    else if (str[j] == '2' || str[j] == '3' || str[j] == '5')
                        res += 5;
                    else if (str[j] == '4')
                        res += 4;
                    else if (str[j] == '6' || str[j] == '9' || str[j] == '0')
                        res += 6;
                    else if (str[j] == '7')
                        res += 3;
                    else if (str[j] == '8')
                        res += 7;
                }
                Console.WriteLine(res + " leds");
            }
        }
    }
}
