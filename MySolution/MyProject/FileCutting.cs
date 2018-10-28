using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class FileCutting
    {
        public static void Main(string[] args)
        {

            string[] fileName = new string[1000];
            int i = 0;
            string str;
            while ((str = Console.ReadLine()) != null)
            {
                fileName[i] = str;
                i++;
            }
            int j = 0;
            while (j < i)
            {
                j += 4; 
                Console.WriteLine(fileName[j]);
                j++;
            }
        }
    }
}
