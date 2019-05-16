﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.DatabaseConnection
{
    public class BlueSheetNameRetrive
    {
        public string getBlueSheetName(int str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string blueSheetName = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select BlueSheetName from BlueSheets where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                blueSheetName += (string)cmd.ExecuteScalar();

            }
            return blueSheetName;
        }
        public int getBlueSheetId(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            int blueSheetId = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select Id from BlueSheets where BlueSheetName = @str";
                cmd.Parameters.AddWithValue("@str", str);
                blueSheetId = (int)cmd.ExecuteScalar();

            }
            return blueSheetId;
        }
    }
}