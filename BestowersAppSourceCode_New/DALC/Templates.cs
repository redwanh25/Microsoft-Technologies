using System;
using System.Data;
using System.Configuration;
using CIS.Lib.Utils;
using System.Data.SqlClient;


namespace CIS.Lib.DALC
{
    //****************************************************************************
    //
    // Templates Class
    // Author: Reza Nabi, reza@ksu.edu, CIS, KSU
    //
    // The Donors class represents a Templates table
    //
    //****************************************************************************
    public class Templates : DAOBase
    {
        public const string TableName = "Templates";
        public const string PrimaryKey = "ID";

        private int _id = 0;
        private string _name = string.Empty;
        private int _organizationId = 0;
        private string _templateContent = string.Empty;
        

        public Templates()
        {
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string TemplateContent
        {
            get { return _templateContent; }
            set { _templateContent = value; }
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


        public bool Load(int id)
        {

            string cmdText = @"SELECT * FROM Templates WHERE ID = @0";

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, id);

            if (ds.Tables[0].Rows.Count < 1)
                return false;

            DataRow dr = ds.Tables[0].Rows[0];
            _id = Convert.ToInt32(dr["ID"]);
            _name = dr["Name"].ToString();
            _organizationId = Convert.ToInt32(dr["OrganizationID"]);
            _templateContent = dr["TemplateContent"].ToString();
           

            return true;
        }



        public bool Load(string templateName, int organizationId)
        {

            string cmdText = @"SELECT * FROM Templates WHERE Name = @0 and OrganizationID = @1";

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, templateName, organizationId);

            if (ds.Tables[0].Rows.Count < 1)
                return false;

            DataRow dr = ds.Tables[0].Rows[0];
            _id = Convert.ToInt32(dr["ID"]);
            _name = dr["Name"].ToString();
            _organizationId = Convert.ToInt32(dr["OrganizationID"]);
            _templateContent = dr["TemplateContent"].ToString();


            return true;
        }


        public DataSet Find(string whereClause, string orderBy)
        {

            string cmdText = @"SELECT t.*,o.Name as OrganizationName,'datacell' as TRClass    
						FROM Templates t, Organization o  
                        WHERE t.OrganizationID = o.ID ";

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



        public int Insert(string name, string templateContent, int organizationId)
        {
            string cmdText = @"INSERT INTO Templates (Name, TemplateContent, OrganizationID) 
							VALUES (@0,@1,@2)";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, name, templateContent, organizationId);

            return rowsAffected;
        }

        public int Update(int id, string name, string templateContent, int organizationId)
        {
            string cmdText = @"UPDATE Templates SET Name=@0, TemplateContent=@1, OrganizationID=@2 WHERE ID=@3";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, name,  templateContent, organizationId, id);
            return rowsAffected;
        }

        public int Delete(int id)
        {
            string cmdText = @"DELETE FROM Templates WHERE ID=@0";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, id);
            return rowsAffected;
        }



    }

}
