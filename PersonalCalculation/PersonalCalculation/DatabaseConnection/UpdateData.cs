using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PersonalCalculation.DatabaseConnection
{
    public class UpdateData
    {
        public void UpdateShareBy(decimal shareBy, int projId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update dbo.ProjectMember set ShareBy = @shareBy where id in ( select Id from ProjectMember where ProjectId = @projectId)";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@shareBy", shareBy);
                cmd.Parameters.AddWithValue("@projectId", projId);

                cmd.ExecuteReader();
            }
        }

        public void UpdateDueMoney(int projId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "dbo.UpdateDueMoney_Procedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@projId", projId);

                cmd.ExecuteReader();
            }
        }

        public void UpdateTotalMoneyCalculationForRentMan(int projId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "dbo.TotalMoneyCalculationForRentMan_Procedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@projectId", projId);

                cmd.ExecuteReader();
            }
        }
    }
}