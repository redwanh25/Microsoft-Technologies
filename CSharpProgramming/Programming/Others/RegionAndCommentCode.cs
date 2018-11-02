using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Others
{
    public class RegionAndCommentCode
    {
        // when you hover over your mouse inside the private fields, properties, methods then you will show all the code

        #region Private Fields
        private int _id;
        private string _firstName;
        private string _lastName;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
        #endregion
    }

    public class Comment
    {
        public static void Main(string[] args)
        {
            HoverOverMouse hom = new HoverOverMouse();
        }
    }

    ///<summary>
    /// i am fine.
    /// what are you doing..?
    /// <para> how are you...? </para>
    /// <para> er moddhe ami ja likhbo. tai show korbe jokhon ami hoverOverMouse data type er upor click korbo. </para>
    ///</summary>
    public class HoverOverMouse
    {

    }
}
