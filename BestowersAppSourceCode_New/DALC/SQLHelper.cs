using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace CIS.Lib.DALC
{
	/// <summary>
	/// This file contains some frequently used methods which excecutes the query and return the resultset.
	/// This will help to make code short and cleaner in DAO objects.
	/// </summary>
	public sealed class SqlHelper
	{
		/// <summary>
		///Since this class provides only static methods, make the default constructor private to prevent 
		/// instances from being created with "new SqlHelper()".
		/// </summary>
		private SqlHelper() {}
		

		/// <summary>
		/// Signature: ExecuteNonQuery(string connString, string cmdText, params object[] parameterValues)
		/// This method is used make insert or update or delete to tables
		/// This method execute the query returns number of rows affected
		/// </summary>
		/// <param name="connString">Connection string</param>
		/// <param name="cmdText">SQL needs to run</param>
		/// <param name="parameterValues">Optional Parameter List</param>
		/// <returns>Number of rows affected</returns>
		public static int ExecuteNonQuery(string connString, string cmdText, params object[] parameterValues)
		{
			SqlConnection conn = new SqlConnection(connString);
			conn.Open();
			SqlCommand cmd = new SqlCommand(cmdText, conn);
			//if we receive parameter values, we need to figure out where they go
			if ((parameterValues != null) && (parameterValues.Length > 0)) 
			{
				//assign the provided values to these parameters based on parameter order
				AssignParameterValues(cmd, parameterValues);
			}
			int nRowsAffected = Convert.ToInt32(cmd.ExecuteNonQuery());
			conn.Close();
			return nRowsAffected;

		}

		/// <summary>
		/// This method execute the query returns SqlDataReader object. This is used when we need read only resultset
		/// </summary>
		/// <param name="connString">Connection string</param>
		/// <param name="cmdText">SQL to run</param>
		/// <param name="parameterValues">Parameter list</param>
		/// <returns></returns>
        
		public static SqlDataReader ExecuteReader(string connString, string cmdText, params object[] parameterValues)
		{
			SqlConnection conn = new SqlConnection(connString);
			conn.Open();
			SqlCommand cmd = new SqlCommand(cmdText, conn);
			//if we receive parameter values, we need to figure out where they go
			if ((parameterValues != null) && (parameterValues.Length > 0)) 
			{
				//assign the provided values to these parameters based on parameter order
				AssignParameterValues(cmd, parameterValues);
			}
			SqlDataReader reader = cmd.ExecuteReader();
			conn.Close();
			return reader;

		}

		/// <summary>
		/// This method execute the query and retrives the first column of the first row. This can be used when we need count or calling function that returns only one record with one column
		/// </summary>
		/// <param name="connString">Connection string</param>
		/// <param name="cmdText">Sql needs to run</param>
		/// <param name="parameterValues">Parameter list</param>
		/// <returns>Returns first column of the first row</returns>
		public static object ExecuteScalar(string connString, string cmdText, params object[] parameterValues)
		{
			SqlConnection conn = new SqlConnection(connString);
			conn.Open();
			SqlCommand cmd = new SqlCommand(cmdText, conn);
			//if we receive parameter values, we need to figure out where they go
			if ((parameterValues != null) && (parameterValues.Length > 0)) 
			{
				//assign the provided values to these parameters based on parameter order
				AssignParameterValues(cmd, parameterValues);
			}
			string result = cmd.ExecuteScalar().ToString();
			conn.Close();
			return result;

		}

		/// <summary>
		/// This method assigns parameters to cmd object
		/// </summary>
		/// <param name="cmd">Command object</param>
		/// <param name="parameterValues">List of parameters</param>
		/// <return>void</return>
		private static void AssignParameterValues(SqlCommand cmd, object[] parameterValues)
		{
			if (parameterValues == null) 
			{
				//do nothing if we get no parameter data
				return;
			}
			//iterate through the Parameter values and add value to command object
			for (int i = 0, j = parameterValues.Length; i < j; i++)
			{
				cmd.Parameters.Add(new SqlParameter("@"+i,parameterValues[i]));
			}
			return;
		}
	
		/// <summary>
		/// This method execute the query return the dataset
		/// </summary>
		/// <param name="connString">Connection string</param>
		/// <param name="cmdText">SQL needs to run</param>
		/// <param name="parameterValues">List of parameters (optional)</param>
		/// <returns>Returns the dataset (resultset)</returns>
		public static DataSet ExecuteDataset(string connString, string cmdText, params object[] parameterValues)
		{
			SqlConnection conn = new SqlConnection(connString);
			SqlCommand cmd = new SqlCommand(cmdText, conn);
			//if we receive parameter values, we need to figure out where they go
			if ((parameterValues != null) && (parameterValues.Length > 0)) 
			{
				//assign the provided values to these parameters based on parameter order
				AssignParameterValues(cmd, parameterValues);
			}
			conn.Open();
			
			//create the DataAdapter & DataSet
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();

			//fill the DataSet using default values for DataTable names, etc.
			da.Fill(ds);

			// close the connection
            conn.Close();
			//return the dataset
			return ds;						
			
		}

	
	}


}
