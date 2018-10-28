using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All
{
    class Clear_Clone
    {
        public static void Main(String[] arg)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            int[] arr1 = arr.Clone() as int[];
            // aitar jonno nicher ai ta output
            // 5 5
            // 1 2 0 0 0
            // 5 5
            // 1 2 3 4 5

            // int[] arr1 = arr;
            // r aitar jonno nicher ai ta output
            // 5 5
            // 1 2 0 0 0
            // 5 5
            // 1 2 0 0 0
            Console.WriteLine(arr.Length + " " + arr1.Length);
            Array.Clear(arr, 2, 3);         // 1 - 3 porjonto shob index k "0" kore dibe. but, delete kore dibe na.

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine(arr.Length + " " + arr1.Length);
            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            String array = "redwan";
        //    String str = array.Clone() as String;
            String str;
            str = array;
            // string er khetre aita hobe na..
            str += "red";
         
            Console.WriteLine(str + " " + array);       // redwanred redwan

            Console.ReadKey();
        }
    }
}
