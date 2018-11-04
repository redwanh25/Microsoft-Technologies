using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Partial_Class
{
    class MainClass3
    {
        public static void Main(string[] args)
        {
            PartialInterface pi = new PartialInterface();
            pi.FirstName();
            pi.LastName();

            IPersonOne pi1 = new PartialInterface();
            pi1.FirstName();
           // pi1.LastName();        // aita likhle error dibe

            IPersonTwo pi2 = new PartialInterface();
            // pi2.FirstName();      // aita likhle error dibe
            pi2.LastName();
        }
    }

    public interface IPersonOne
    {
        void FirstName();
    }
    public interface IPersonTwo
    {
        void LastName();
    }
}
