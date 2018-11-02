using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.ExceptionHandling
{
    class Basic
    {
        public static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\Redwan\Desktop\Desktop Folder\txt file\code1.txt");
                string str = streamReader.ReadToEnd();
                Console.WriteLine(str);
            }
            catch (FileNotFoundException ex)
            {
                try
                {
                    streamReader = new StreamReader(@"C:\Users\Redwan\Desktop\Desktop Folder\txt file\code1.txt");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.GetType().Name);
                }
                Console.WriteLine(ex.FileName);
                Console.WriteLine();
                //Console.WriteLine(ex.StackTrace + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Execute");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                //Console.WriteLine(ex.StackTrace + "\n");
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block");
            }
        }

    }
}
