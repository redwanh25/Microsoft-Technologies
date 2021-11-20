using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.AsyncTaskAwait
{
    internal class AsyncTaskAwait_1
    {
        static void Main(string[] args)
        {
            Method1();
            Method3();
            Method2();
            Console.ReadKey();
        }

        public static async void Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 1 -----------");
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2 --");
                Task.Delay(100).Wait();
            }
        }

        public static async void Method3()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 3 ------------------------------");
                    Task.Delay(100).Wait();
                }
            });
        }

    }
}
