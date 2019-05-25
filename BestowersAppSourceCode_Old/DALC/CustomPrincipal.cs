using System;
using System.Security.Principal;

namespace CIS.Lib.DALC
{

	//****************************************************************************
	// 
	// CustomPrincipal Class
	// Author: Reza Nabi, reza@ksu.edu, CMS, KSU
	//
	// The CustomPrincipal class implements the IPrincipal interface so it 
	// can be used in place of the GenericPrincipal object.  Requirements for 
	// implementing the IPrincipal interface include implementing the
	// IIdentity interface and an implementation for IsInRole.  The custom
	// principal is attached to the current request in Global.asax in the
	// Authenticate_Request event handler.  The userID and UserRole are stroed in  
	// custom principal object in the Global_AcquireRequestState event handler.
	//
	//****************************************************************************
	
	
	public class CustomPrincipal : IPrincipal
	{
		private int		_userID;
		private string	_userRole = String.Empty;
        private int _organizationId;
		

		// Required to implement the IPrincipal interface.
		protected IIdentity _Identity;
		/// <summary>
		/// Default constructor
		/// </summary>
		public CustomPrincipal()
		{
		}
		/// <summary>
		/// Constructor with identity,userid and userrole
		/// </summary>
		/// <param name="identity">Identity</param>
		/// <param name="userID">User ID </param>
		/// <param name="userRole">User Role</param>
        /// <param name="organizaitonid">Organization ID</param>
		public CustomPrincipal(IIdentity identity,int userID,string userRole,int organizationId)
		{
			_Identity = identity;
			_userID = userID;
			_userRole = userRole;
            _organizationId = organizationId;
		}

        /// <summary>
        /// Constructor with identity,userid and userrole
        /// </summary>
        /// <param name="identity">Identity</param>
        /// <param name="userID">User ID </param>
        /// <param name="userRole">User Role</param>
        public CustomPrincipal(IIdentity identity, int userID, string userRole)
        {
            _Identity = identity;
            _userID = userID;
            _userRole = userRole;
            
        }

		// IIdentity property used to retrieve the Identity object attached to
		// this principal.
		public IIdentity Identity
		{
			get	{ return _Identity; }
			set	{ _Identity = value; }
		}
		
		// The user's ID, created when the user was inserted into the database
		public int UserID
		{
			get { return _userID; }
			set { _userID = value; }
		}
        public int OrganizationID
        {
            get { return _organizationId; }
            set { _organizationId = value; }
        }
		// The user's role, as defined in TTUser.
		public string UserRole
		{
			get { return _userRole; }
			set { _userRole = value; }
		}


		
		public bool IsInRole(string role)
		{
			string [] roleArray = role.Split(new char[] {','});

			foreach (string r in roleArray)
			{
				if (_userRole == r)
					return true;
			}
			return false;
		}
		

	
	}
}
