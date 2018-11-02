using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.NewFolder2
{
    class Class1
    {
        int[] arr = new int[6];
        int i = -1;

        void push(int data)
        {
            if (i == 5)
            {
                Console.WriteLine("stack is full");
            }
            else
            {
                arr[++i] = data;
            }
        }

        void pop()
        {
            i--;
        }

        int top()
        {
            return arr[i];
        }

        void print()
        {
            int j;

            for (j = 0; j <= i; j++)
            {
                Console.Write(arr[j] + " ");
            }

            Console.WriteLine();
        }
        public static void Main()
        {
            Class1 c = new Class1();
            int n = 4, m, val;
            for (m = 0; m < n; m++)
            {
                 val = int.Parse(Console.ReadLine());
                c.push(val);
            }
            Console.WriteLine(c.top());
            //pop();
            c.print();
            val = int.Parse(Console.ReadLine());
            c.push(val);
            c.print();
            val = int.Parse(Console.ReadLine());
            c.push(val);
            c.print();
            val = int.Parse(Console.ReadLine());
            c.push(val);
            c.print();
            val = int.Parse(Console.ReadLine());
            c.push(val);
            c.print();
            val = int.Parse(Console.ReadLine());
            c.push(val);
            c.print();
        }
    }
}
