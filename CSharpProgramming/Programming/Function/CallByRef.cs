using System;
using System.Collections;

namespace Programming.Function
{
    class CallByRef
    {
        public void Method(ref int a)
        {
            a *= a;
            Console.WriteLine("outside the main method {0}", a);
        }

        public void MethodArray(ref int[] arr)
        {
            int i = 0;
            foreach(int a in arr)
            {
                arr[i] = a * i++;
         //       arr[i++] = a * i;      aiter jonno different output ashbe.
             //   i++;
             //   Console.WriteLine(arr[0]);
            }
        }

        public static void Main(String[] arg)
        {
            int a = 50;
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("inside the main method {0}", a);
            CallByRef call = new CallByRef();
            call.Method(ref a);
            call.MethodArray(ref arr);      // ref use na korle o array er khetre ref e jay actually. java te o, c/c++ te o.
            for (IEnumerator it = arr.GetEnumerator(); it.MoveNext(); Console.WriteLine(it.Current)) ;
            Console.WriteLine("inside the main method {0}", a);
            Array.ForEach(arr, Console.WriteLine);
            Console.ReadKey();
        }
    }
}
