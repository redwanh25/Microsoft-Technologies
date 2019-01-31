using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.NewFolder2
{
    class BinaryDigite
    {
        public static int[] a = new int[100];
        public static int n = 0;

        public static void print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
        public static void binary(int i)
        {
            if (i == n)
            {
                print();
                return;
            }
            a[i] = 0;
            binary(i + 1);
            a[i] = 1;
            binary(i + 1);
        }
        public static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            BinaryDigite.binary(0);
        }
    }
}
