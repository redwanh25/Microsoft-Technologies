using System;
using System.Data;
using System.Configuration;
using CIS.Lib.Utils;
using System.Data.SqlClient;

//****************************************************************************
//
// Expenses Class
// Author: Reza Nabi, reza@ksu.edu, CIS, KSU
//
// The Donations class represents Expenses table in the database.
//
//****************************************************************************

namespace CIS.Lib.DALC
{
    public class Expenses : DAOBase
    {
        public const string TableName = "Expenses";
        public const string PrimaryKey = "ID";

        private int _id;
        private int _projectId;
        private double _amount;
        private int _fundId;
        private DateTime _expenseDate;
        private string _purpose = string.Empty;
        private string _comments = string.Empty;
        private int _treeId = 0;
        private int _organizationId;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int ProjectID
        {
            get { return _projectId; }
            set { _projectId = value; }
        }
        public Double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public int FundID
        {
            get { return _fundId; }
            set { _fundId = value; }
        }
        public DateTime ExpenseDate
        {
            get { return _expenseDate; }
            set { _expenseDate = value; }
        }
        
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        public int TreeID
        {
            get { return _treeId; }
            set { _treeId = value; }
        }
        public int OrganizationID
        {
            get { return _organizationId; }
            set { _organizationId = value; }
        }

        public Expenses()
        {
        }

        public bool Load(int id)
        {

            string cmdText = @"SELECT * FROM Expenses WHERE ID = @0";

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, id);

            if (ds.Tables[0].Rows.Count < 1)
                return false;

            DataRow dr = ds.Tables[0].Rows[0];
            _id = Convert.ToInt32(dr["ID"]);
            _projectId = Convert.ToInt32(dr["ProjectID"]);
            _amount = Convert.ToDouble(dr["Amount"]);
            _fundId = Convert.ToInt32(dr["FundID"]);
            _expenseDate = Convert.ToDateTime(dr["ExpenseDate"]);
            _purpose = Convert.ToString(dr["Purpose"]);
            _comments = dr["Comments"].ToString();
            if ((String.IsNullOrEmpty(dr["TreeID"].ToString())) == false)
            {
                _treeId = Convert.ToInt32(dr["TreeID"]);
            }
            _organizationId = Convert.ToInt32(dr["OrganizationID"]);


            return true;
        }


        public DataSet Find(string whereClause, string orderBy, string strLimit)
        {

            string cmdText = @"SELECT " + strLimit + @" e.*, p.Name as ProjectName,
                                f.Name as FundName, 'datacell' as TRClass      
						        FROM Expenses e, Projects p, Fund f
                                WHERE e.ProjectID = p.ID 
                                    AND e.FundID = f.ID 
                            ";

            if (whereClause != string.Empty)
            {
                cmdText = cmdText + " AND " + whereClause;
            }
            if (orderBy != string.Empty)
            {
                cmdText = cmdText + " " + orderBy;
            }

            //CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdText, "SQL RAN TO GET DONATOINS");

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText);
            return ds;
        }


        public DataSet FindExpensesByFund(string whereClause, string orderBy)
        {
            string defOrderBy = " ORDER BY SumOfAmount DESC";

            string cmdText = @"
                            SELECT Expenses.FundID, 
                            CAST (Sum(Expenses.Amount) AS NUMERIC(10,2)) AS SumOfAmount,
                            Fund.Name as FundName,
                            'datacell' as TRClass,
                            '2' as SectionID
                            FROM Expenses INNER JOIN Fund ON Expenses.FundID = Fund.ID
                            WHERE " + whereClause + @" 
                            GROUP BY Expenses.FundID, Fund.Name
                            ";

            // Add the sorting ORDER BY clause 
            if (orderBy != string.Empty)
            {
                cmdText = cmdText + " " + orderBy;
            }
            else
            {
                cmdText = cmdText + " " + defOrderBy;
            }

            CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdText, "SQL RAN TO GET EXPENSES by FUND");

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText);
            return ds;
        }



        public int Insert(int projectId, double amount, int fundId, DateTime expenseDate, string purpose, string comments, int treeId, int organizationId)
        {
            string cmdText = @"INSERT INTO Expenses (ProjectID, Amount, FundID, ExpenseDate, Purpose, Comments, TreeID, OrganizationID) 
							VALUES (@0, @1, @2, @3, @4, @5, @6, @7)";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, projectId, amount, fundId, expenseDate, purpose, comments, treeId, organizationId);

            return rowsAffected;
        }

        public int Update(int id, int projectId, double amount, int fundId, DateTime expenseDate, string purpose, string comments, int treeId, int organizationId)
        {
            string cmdText = @"UPDATE Expenses SET ProjectID=@0, Amount=@1, FundID=@2, ExpenseDate=@3, Purpose=@4, Comments=@5, TreeID=@6, OrganizationID = @7 WHERE ID=@8";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, projectId, amount, fundId, expenseDate, purpose, comments, treeId, organizationId, id);
            return rowsAffected;
        }

        public int Delete(int id)
        {
            string cmdText = @"DELETE FROM Expenses WHERE ID=@0";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, id);
            return rowsAffected;

        }

    }
}
