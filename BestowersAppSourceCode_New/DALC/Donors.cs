using System;
using System.Data;
using System.Configuration;
using CIS.Lib.Utils;
using System.Data.SqlClient;


namespace CIS.Lib.DALC
{
	//****************************************************************************
	//
	// Donors Class
	// Author: Reza Nabi, reza@ksu.edu, CIS, KSU
	//
	// The Donors class represents a Donors table
	//
	//****************************************************************************

    public class Donors : DAOBase
    {
        public const string TableName = "Donors";
        public const string PrimaryKey = "ID";
		
		private int	_id = 0;
		private string _fullName = string.Empty;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;	
	    private string _email = string.Empty;
        private string _phone = string.Empty;
        private int _organizationId = 0;

		public Donors()
		{
		}
        
		

		public string FullName
		{
            get { return _fullName; }
            set { _fullName = value; }
		}

		
		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		public string Phone
		{
			get { return _phone; }
            set { _phone = value; }
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

        public int OrganizationID
        {
            get { return _organizationId; }
            set { _organizationId = value; }
        }


		public bool Load (int id)
		{
            
			string cmdText= @"SELECT * FROM Donors WHERE ID = @0";

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, id); 

			if (ds.Tables[0].Rows.Count < 1)
				return false;

			DataRow dr = ds.Tables[0].Rows[0];
			_id = Convert.ToInt32(dr["ID"]);
			_fullName = dr["FullName"].ToString();
			_phone = dr["Phone"].ToString();
			_email = dr["Email"].ToString();
            _lastName = dr["LastName"].ToString();
            _firstName = dr["FirstName"].ToString();
            _organizationId = Convert.ToInt32(dr["OrganizationID"]);
		

			return true;
		}


        public int Insert(string fullName, string firstName, string lastName, string email, string phone, int organizationId)
        {
            string cmdText = @"INSERT INTO Donors (FullName,FirstName,LastName,Email,Phone, OrganizationID) 
							VALUES (@0,@1,@2,@3,@4,@5)";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, fullName, firstName, lastName, email, phone, organizationId);

            return rowsAffected;
        }

        public int Update(int id, string fullName, string firstName, string lastName, string email, string phone, int organizationId)
		{
            string cmdText = @"UPDATE Donors SET FullName=@0, FirstName=@1,LastName=@2,Email=@3, Phone=@4, OrganizationID = @5 WHERE ID=@6";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, fullName, firstName, lastName, email, phone, organizationId, id); 
			return rowsAffected;			
		}

		public int Delete(int id)
		{
			string cmdText = @"DELETE FROM Donors WHERE ID=@0";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, id); 
			return rowsAffected;			
		}



    }
}
