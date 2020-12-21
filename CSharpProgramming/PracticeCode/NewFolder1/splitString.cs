using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.NewFolder1
{
    class splitString
    {
        public static void Main()
        {
            //string[] str = "Redwan ".Split(new[] { ' ' }); // just need to change.
            //int cnt = str.Length;
            //Console.WriteLine(cnt);
            string str = "NAFI";
            string firstName = str.Substring(0, str.LastIndexOf(" "));
            string lastName = str.Substring(str.LastIndexOf(" ") + 1);
            Console.WriteLine("FirstName: " + firstName + "//LastName: " + lastName + "//");
            Console.ReadKey();
        }
    }
}
