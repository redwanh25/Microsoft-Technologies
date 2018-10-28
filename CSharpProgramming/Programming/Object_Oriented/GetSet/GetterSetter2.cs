using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.GetSet
{
    public class TestEmployee
    {
        private static int counter;

        public TestEmployee()
        {
            counter++;
        }
        public static int Counter
        {
            get
            {
                return counter;
            }
        }
    }

    public class GetterSetter2
    {
        public static void Main(string[] args)
        {
            TestEmployee e1 = new TestEmployee();
            TestEmployee e2 = new TestEmployee();
            TestEmployee e3 = new TestEmployee();
            //TestEmployee.Counter = 10;//Compile Time Error: Can't set value  

            Console.WriteLine("No. of Employees: " + TestEmployee.Counter);
        }
    }
}
