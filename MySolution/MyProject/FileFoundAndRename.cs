using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProject
{
    class FileFoundAndRename
    {
        public static void Main(string[] args)
        {
            string root = @"F:\Coding Tutorial\web application development\JavaScript with ASP.NET tutorial\";
            string[] fileName = new string[1000];
            string str;
            int i = 0, num = 1;
            FileInfo file;
            while ((str = Console.ReadLine()) != null)
            {
                fileName[i] = root + str + ".mp4";
                if (File.Exists(fileName[i]))
                {
                    file = new FileInfo(fileName[i]);
                    Rename(file, num + ". " + str + ".mp4");
                }
                num++;
                i++;
            }
        }

        public static void Rename(FileInfo fileInfo, string newName)
        {
            //Console.WriteLine(fileInfo.Directory.FullName);
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + newName);
        }
    }
}
