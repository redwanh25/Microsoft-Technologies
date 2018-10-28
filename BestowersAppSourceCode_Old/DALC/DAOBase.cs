using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CIS.Lib.Utils;

namespace CIS.Lib.DALC
{
	//****************************************************************************
	// 
	// DAOBase Class
	// Author: Reza Nabi, reza@ksu.edu, CIS, KSU
	//
	// This is an abstract class which has Find methods
	// applied to all DAO objects.
	//
	//****************************************************************************
	public abstract class DAOBase
	{

		
		public DataSet Find(string dbConn, string tableName, string whereClause, string orderBy)
		{
			string cmdText = "SELECT * FROM " + tableName;
			if (whereClause != string.Empty) 
			{
				cmdText = cmdText + " WHERE " + whereClause;
			}
			if (orderBy != string.Empty) 
			{
				cmdText = cmdText + " " + orderBy;
			}
			DataSet ds = SqlHelper.ExecuteDataset(dbConn, cmdText); 
			return ds;
		}


	}
}
