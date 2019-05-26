using System;
using System.Data;
using System.Configuration;
using CIS.Lib.Utils;
using System.Data.SqlClient;


namespace CIS.Lib.DALC
{
	//****************************************************************************
	//
	// Fund Class
	// Author: Reza Nabi, reza@ksu.edu, CIS, KSU
	//
	// The Donors class represents a Fund table
	//
	//****************************************************************************
    public class Fund : DAOBase
    
         {
        public const string TableName = "Fund";
        public const string PrimaryKey = "ID";
		
		private int	_id = 0;
		private string _name = string.Empty;        
        private int _organizationId = 0;
		

		public Fund()
		{
		}
        
		public string Name
		{
            get { return _name; }
            set { _name = value; }
		}

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}
        public int OrganizationID
        {
            get { return _organizationId; }
            set { _organizationId = value; }
        }


		public bool Load (int id)
		{
            
			string cmdText= @"SELECT * FROM Fund WHERE ID = @0";

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, id); 

			if (ds.Tables[0].Rows.Count < 1)
				return false;

			DataRow dr = ds.Tables[0].Rows[0];
			_id = Convert.ToInt32(dr["ID"]);
			_name = dr["Name"].ToString();
            _organizationId = Convert.ToInt32(dr["OrganizationID"]);
			            

			return true;
		}

       
        public int Insert(string name, int organizationId)
        {
            string cmdText = @"INSERT INTO Fund (Name,OrganizationID) 
							VALUES (@0,@1)";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, name, organizationId);

            return rowsAffected;
        }

        public int Update(int id, string name, int organizationId)
		{
            string cmdText = @"UPDATE Fund SET Name=@0, OrganizationID=@1 WHERE ID=@2";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, name, organizationId, id); 
			return rowsAffected;			
		}

		public int Delete(int id)
		{
			string cmdText = @"DELETE FROM Fund WHERE ID=@0";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, id); 
			return rowsAffected;			
		}



    }

}
