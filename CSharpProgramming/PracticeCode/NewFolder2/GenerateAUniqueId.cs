using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.NewFolder2
{
    class GenerateAUniqueId
    {
        public static void Main(string[] args)
        {

            byte[] buffer1 = Guid.NewGuid().ToByteArray();
            string number = BitConverter.ToUInt32(buffer1, 8).ToString();
            number += String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            byte[] buffer2 = Guid.NewGuid().ToByteArray();
            number += BitConverter.ToUInt32(buffer2, 8).ToString();
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
