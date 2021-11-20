using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.AsyncTaskAwait
{
    internal class AsyncTaskAwait_3
    {
        static async Task Main(string[] args)
        {
            await callMethod();
            Console.ReadKey();
        }

        public static async Task callMethod()
        {
            Method2();
            var count = await Method1();
            Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 1 -----------");
                    Task.Delay(100).Wait();
                    count += 1;
                }
            });
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2 ------------------------------");
                Task.Delay(100).Wait();
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
    }
}
