using System;
using System.Data;
using System.Configuration;
using CIS.Lib.Utils;
using System.Data.SqlClient;


namespace CIS.Lib.DALC
{
    //****************************************************************************
    //
    // UserRole Class
    // Author: Reza Nabi, reza@ksu.edu, CIS, KSU
    //
    // The UserRole class represents Role table in the database.
    //
    //****************************************************************************

    public class UserRole : DAOBase
    {
        public const string TableName = "Role";
        public const string PrimaryKey = "RoleID";

        private int _id;
        private string _name = string.Empty;
        private int _organizationId;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int OrganizationID
        {
            get { return _organizationId; }
            set { _organizationId = value; }
        }

        public UserRole()
        {
        }

        public int Insert(string name, int organizationId)
        {
            string cmdText = @"INSERT INTO Role (Name, OrganizationID) 
							VALUES (@0, @1)";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, name, organizationId);

            return rowsAffected;
        }

        public int Update(int id, string name, int organizationId)
        {
            string cmdText = @"UPDATE Role SET Name=@0, OrganizaitonID = @1 WHERE RoleID=@2";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, name, organizationId, id);
            return rowsAffected;
        }

        public int Delete(int id)
        {
            string cmdText = @"DELETE FROM Role WHERE RoleID=@0";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, id);
            return rowsAffected;
            
        }
        
    }
}
