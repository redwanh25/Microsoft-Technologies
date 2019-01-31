using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiuAlgorithmAssignment.DIUVarsity
{
    class QRCodeScanner
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] id_num_size = str.Split('"');

            string std_id = id_num_size[3];
            string token_number = id_num_size[7];
            string tshirt_size = id_num_size[11];

            Console.WriteLine(std_id);
            Console.WriteLine(token_number);
            Console.WriteLine(tshirt_size);

            foreach (string s in id_num_size){
                Console.WriteLine(s);
            }
        }
    }
}
