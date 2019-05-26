using System;
using System.Data;
using System.Configuration;
using CIS.Lib.Utils;
using System.Data.SqlClient;


namespace CIS.Lib.DALC
{
    //****************************************************************************
    //
    // Organization Class
    // Author: Reza Nabi, reza@ksu.edu, CIS, KSU
    //
    // The Donors class represents a Organization table
    //
    //****************************************************************************
    public class Organization : DAOBase
    {
        public const string TableName = "Organization";
        public const string PrimaryKey = "ID";

        private int _id = 0;
        private string _name = string.Empty;


        public Organization()
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
        


        public bool Load(int id)
        {

            string cmdText = @"SELECT * FROM Organization WHERE ID = @0";

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, id);

            if (ds.Tables[0].Rows.Count < 1)
                return false;

            DataRow dr = ds.Tables[0].Rows[0];
            _id = Convert.ToInt32(dr["ID"]);
            _name = dr["Name"].ToString();
            

            return true;
        }


        public int Insert(string name, int organizationId)
        {
            string cmdText = @"INSERT INTO Organization (Name) 
							VALUES (@0)";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, name);

            return rowsAffected;
        }

        public int Update(int id, string name)
        {
            string cmdText = @"UPDATE Organization SET Name=@0 WHERE ID=@1";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, name, id);
            return rowsAffected;
        }

        public int Delete(int id)
        {
            string cmdText = @"DELETE FROM Organization WHERE ID=@0";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, id);
            return rowsAffected;
        }



    }

}
