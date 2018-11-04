using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Partial_Class
{
    /// <summary>
    /// ai ta hoye gese "class PartialInterface : IPersonTwo, IPersonOne" emon
    /// </summary>
    partial class PartialInterface : IPersonTwo
    {
        public void FirstName()         // ai method ta k amra onno jei partial class ase or moddhe o korte partam.
        {
            Console.WriteLine("First Name");
        }

        public void LastName()
        {
            Console.WriteLine("Last Name");
        }

    }
}
