using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Programming.ExceptionHandling
{
    public class CustomException
    {
        public static void Main(string[] args)
        {
            int a = 6, b = 2;
            try
            {
                if (a % b == 0)
                {
                    //throw new Exception();
                    //throw new Exception("Redwan hossain");
                    //throw new myException();
                    throw new MyException("Redwan");    // aikhane parameter dite hole myException class a akta constructor toiri korte hobe
                                                        // and constructor theke "super" diye parent class er constructor a call korte hobe.  
                }
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);  // er mane hosse amk details bole dibe  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);  // er mane hosse amk details bole dibe 
            }
        }
    }


    [Serializable]          // aita mane hosse akta application theke arekat application er shathe add kora jabe. aita na dile o kono problem nai. code run hobe. 
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }


        public MyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public MyException(SerializationInfo info, StreamingContext context) : base(info, context)  // for Serializable
        {
        }
    }
}
