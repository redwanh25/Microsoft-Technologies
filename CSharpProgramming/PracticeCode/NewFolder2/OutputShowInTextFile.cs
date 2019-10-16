using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.NewFolder2
{
    class OutputShowInTextFile
    {
        public static void Main(string[] arg)
        {
            List<string> list = new List<string>();
            string str;
            string filePath = @"C:\Users\Redwan\Desktop\Text_File.txt";

            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    while ((str = Console.ReadLine()) != null)
                    {
                        sw.WriteLine(str);
                    }            
                }
            }
            else
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    while((str = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }

                //list = File.ReadAllLines(filePath).ToList();
                //foreach (string s in list)
                //{
                //    Console.WriteLine(s);
                //}
            }
            
        }
    }
}
