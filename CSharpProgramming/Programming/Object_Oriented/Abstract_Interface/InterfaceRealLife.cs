using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Object_Oriented.Abstract_Interface
{
    // please read 198 page, interface vs abstract (A N M bojlur rahman)

    interface Payment
    {
        long getPayment();
    }

    class Bkash : Payment
    {
        public long getPayment()
        {
            Console.WriteLine("Bkash ");
            return 100;
        }
    }

    class Brac : Payment
    {
        public long getPayment()
        {
            Console.WriteLine("Brac ");
            return 200;
        }
    }

    class PaymentEngine
    {
        public void accepted(Payment p)
        {
            Console.WriteLine(p.getPayment());
        }
    }

    public class InterfaceRealLife
    {
        public static void Main(String[] args)
        {
            PaymentEngine E = new PaymentEngine();

            Bkash B = new Bkash();
            E.accepted(B);

            Brac C = new Brac();
            E.accepted(C);
        }
    }
}
