using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Partial_Class
{
    /// <summary>
    /// akta SamplePartialClass class inharite korlei dui ta class ao automatic inharite hoye jabe.
    /// ai class a abr onno kono class k inharite korle multiple inharitance er moto hoye jabe. but, c# multiple inharitance
    /// suport kore na.
    /// <para>so be careful..</para>
    /// </summary>

    partial class SamplePartialClass
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
