using System;
using System.Data;
using System.Configuration;
using CIS.Lib.Utils;
using System.Data.SqlClient;


namespace CIS.Lib.DALC
{
	//****************************************************************************
	//
	// AppUser Class
	// Author: Reza Nabi, reza@ksu.edu, CIS, KSU
	//
	// The AppUser class represents a CIS user, including their unique
	// userID and UserName.  Role information retrieved from the database
	// is also stored in the AppUser class.
	//
	//****************************************************************************

	public class AppUser : DAOBase
	{
		public const string UserRoleNone = "0";
        public const string TableName = "AppUser";
        public const string PrimaryKey = "UserID";
		
		private string _password = string.Empty;
		private string _role = UserRoleNone;
		private int	_userID = 0;
		private string _userName = string.Empty;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;	
	    private string _email = string.Empty;
        private bool _passwordExpired = false;
        private int _organizationId = 0;

		public AppUser()
		{
		}
        
		public AppUser(string UserName)
		{
			_userName = UserName;
		}

		public AppUser(int UserID, string UserName, string Role)
		{
			_userID = UserID;
			_userName = UserName;
			_role = Role;
		}

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		public string Role
		{
			get { return _role; }
			set { _role = value; }
		}
        public int OrganizationID
        {
            get { return _organizationId; }
            set { _organizationId = value; }
        }
        public bool PasswordExpired
        {
            get { return _passwordExpired; }
            set { _passwordExpired = value; }
        }
		public int UserID
		{
			get { return _userID; }
			set { _userID = value; }
		}

		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

      

        public string Email
        {
            get { return _email; }
            set { _email = value; }
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
		/// <summary>
		/// Login method authenticate user with username/password they provide
		/// </summary>
		/// <param name="username">User Name</param>
		/// <param name="password">Password</param>
		/// <returns>Returns true if username and password exists in our database otherwise false</returns>
		public bool Login(string username, string password)
		{
			string cmdText = "select count(*) FROM AppUser WHERE UserName=@0 AND Password=@1";
			string userExists = Convert.ToString(SqlHelper.ExecuteScalar(AppSetting.GetConnString(),cmdText,username,password));
			return (userExists.Equals("1")) ? true : false;
		}
		/// <summary>
		/// It loads users info. username is given
		/// </summary>
		/// <returns>Retruns true if it finds the user by user name otherwise false</returns>
		public bool Load ()
		{
            
			string cmdText = "select * from AppUser where UserName=@0";
			
			// Get the user's information from the database
            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, _userName); 

			if (ds.Tables[0].Rows.Count < 1)
				return false;

			DataRow dr = ds.Tables[0].Rows[0];
			_userID = Convert.ToInt32(dr["UserID"]);
			_userName = dr["UserName"].ToString();
			_role = dr["RoleID"].ToString();
            _firstName = dr["FirstName"].ToString();
            _lastName = dr["LastName"].ToString();
            _organizationId = Convert.ToInt32(dr["OrganizationID"]);
            


			return true;
		}		

		public bool Load (int id)
		{
            
			string cmdText= @"SELECT * FROM AppUser WHERE UserID = @0";

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, id); 

			if (ds.Tables[0].Rows.Count < 1)
				return false;

			DataRow dr = ds.Tables[0].Rows[0];
			_userID = Convert.ToInt32(dr["UserID"]);
			_userName = dr["UserName"].ToString();
			_role = dr["RoleID"].ToString();
			_password = dr["Password"].ToString();
            _email = dr["Email"].ToString();
            _lastName = dr["LastName"].ToString();
            _firstName = dr["FirstName"].ToString();
            

			return true;
		}

        public bool Load(string userName,string email)
        {

            string cmdText = @"SELECT * FROM AppUser WHERE UserName = @0 and Email=@1";

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, userName,email);

            if (ds.Tables[0].Rows.Count < 1)
                return false;

            DataRow dr = ds.Tables[0].Rows[0];
            _userID = Convert.ToInt32(dr["UserID"]);
            _userName = dr["UserName"].ToString();
            _role = dr["RoleID"].ToString();
            _password = dr["Password"].ToString();
            _email = dr["Email"].ToString();

            _firstName = dr["FirstName"].ToString();
            _lastName = dr["LastName"].ToString();
            

            return true;
        }

        public DataSet Find(string whereClause, string orderBy)
        {

            string cmdText = @"SELECT u.*,r.Name as RoleName,'datacell' as TRClass    
						FROM AppUser u, Role r  
                        WHERE u.RoleID = r.RoleID ";

            if (whereClause != string.Empty)
            {
                cmdText = cmdText + " AND " + whereClause;
            }
            if (orderBy != string.Empty)
            {
                cmdText = cmdText + " " + orderBy;
            }
            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText);
            return ds;
        }

        public DataSet FindOrcaMembers(string whereClause, string orderBy)
        {

            string strDefOrderBy = @" ORDER BY m.BatchID, m.CadetNo ";
            string cmdText = @"SELECT m.MemberID, m.FirstName, m.LastName, m.BatchID, m.CadetNo, m.HomeEmail, m.HomePhone, m.City, m.State, m.CountryID    
						FROM Member m ";

            if (whereClause != string.Empty)
            {
                cmdText = cmdText + "  WHERE " + whereClause;
            }

            if (orderBy != string.Empty)
            {
                cmdText = cmdText + " " + orderBy;
            }
            else
            {
                cmdText = cmdText + " " + strDefOrderBy;
            }

            //CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdText, "SQL RAN TO GET ORCA MEMBERS");

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText);
            return ds;
        }

        public DataSet SearchOrcaMembers(string whereClause, string orderBy)
        {

            string strDefOrderBy = @" ORDER BY m.BatchID, m.CadetNo ";
            string cmdText = @"SELECT m.MemberID, m.FirstName, m.LastName, 
                                m.BatchID, m.CadetNo, m.HomeEmail, 
                                m.HomePhone, m.City, m.State, m.CountryID, 'datacell' as TRClass    
						       FROM Member m ";

            if (whereClause != string.Empty)
            {
                cmdText = cmdText + "  WHERE " + whereClause;
            }

            if (orderBy != string.Empty)
            {
                cmdText = cmdText + " " + orderBy;
            }
            else
            {
                cmdText = cmdText + " " + strDefOrderBy;
            }

            //CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdText, "SQL RAN TO GET ORCA MEMBERS");

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText);
            return ds;
        }

        /// <summary>
        /// Login method authenticate user with username/password they provide
        /// </summary>
        /// <param name="username">User Name</param>
        /// <param name="password">Password</param>
        /// <returns>Returns true if username and password exists in our database otherwise false</returns>
        public bool AuthenticateOrcaMember(string username, string password)
        {
            string cmdText = "select count(*) FROM Member WHERE CadetNo=@0 AND Password=@1";
            string userExists = Convert.ToString(SqlHelper.ExecuteScalar(AppSetting.GetConnString(), cmdText, username, password));

            //CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdText, "SQL RAN TO authenticate ");

            return (userExists.Equals("1")) ? true : false;
        }

        public bool Load(string email)
        {
            string cmdText = @"SELECT * FROM AppUser WHERE UserName = @0";

            DataSet ds = SqlHelper.ExecuteDataset(ConfigurationSettings.AppSettings["DBConnString"], cmdText, email);

            if (ds.Tables[0].Rows.Count < 1)
                return false;

            DataRow dr = ds.Tables[0].Rows[0];
            _userID = Convert.ToInt32(dr["UserID"]);
            _userName = dr["UserName"].ToString();
            _role = dr["RoleID"].ToString();
            _password = dr["Password"].ToString();
            _passwordExpired = Convert.ToBoolean(dr["PasswordExpired"]);

            return true;
        }

        public bool ChangePassword(string username, string password)
        {
            AppUser user = new AppUser(username);
            if (!(user.Load()))
            {
                return false;
            }
            else
            {
                // change password
                string updateCmdText = "UPDATE AppUser SET Password = @0, PasswordExpired = 0 WHERE UserName = @1";
                int result = SqlHelper.ExecuteNonQuery(ConfigurationSettings.AppSettings["DBConnString"], updateCmdText, password, username);
                return true;
            }
        }

        public int Insert(int roleId, string firstName, string lastName, string email, string userName, string passwd, bool passwordExpired, int orgId)
        {
            string cmdText = @"INSERT INTO AppUser (RoleId,FirstName,LastName,Email,UserName,Password,PasswordExpired,OrganizationID) 
							VALUES (@0,@1,@2,@3,@4,@5,@6,@7)";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, roleId, firstName, lastName, email, userName, passwd, passwordExpired, orgId);

            return rowsAffected;
        }

        public int Update(int userId, int roleId, string firstName, string lastName, string email, string userName, string passwd, bool passwordExpired, int orgId)
		{
			string cmdText = @"UPDATE AppUser SET RoleID=@0, UserName=@1,Password=@2,Email=@3,FirstName=@4,LastName=@5, PasswordExpired=@6, OrganizationID=@7 WHERE UserID=@8";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, roleId, userName, passwd, email, firstName, lastName, passwordExpired,orgId, userId); 
			return rowsAffected;			
		}

		public int Delete(int id)
		{
			string cmdText = @"DELETE FROM AppUser WHERE UserID=@0";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, id); 
			return rowsAffected;			
		}

	}	
}
