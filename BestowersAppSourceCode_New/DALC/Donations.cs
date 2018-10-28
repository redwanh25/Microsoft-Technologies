using System;
using System.Data;
using System.Configuration;
using CIS.Lib.Utils;
using System.Data.SqlClient;

//****************************************************************************
//
// Donations Class
// Author: Reza Nabi, reza@ksu.edu, CIS, KSU
//
// The Donations class represents Donations table in the database.
//
//****************************************************************************

namespace CIS.Lib.DALC
{
    public class Donations : DAOBase
    {
        public const string TableName = "Donaitons";
        public const string PrimaryKey = "ID";

        private int _id;
        private int _donorId;
        private double _amount;
        private int _fundId;
        private DateTime _donationDate;
        private string _displayName = string.Empty;
        private bool _anonymous = false;
        private string _purpose = string.Empty;
        private string _comments = string.Empty;
        private int _treeId = 0;
        private int _organizationId;
        private string _cDonationDate;
        private bool _receiptSent = false;
        private DateTime _receiptSentDate;
        

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int DonorID
        {
            get { return _donorId; }
            set { _donorId = value; }
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
        public DateTime DonationDate
        {
            get { return _donationDate; }
            set { _donationDate = value; }
        }
        public DateTime ReceiptSentDate
        {
            get { return _receiptSentDate; }
            set { _receiptSentDate = value; }
        }
        public string CDonationDate
        {
            get { return _cDonationDate; }
            set { _cDonationDate = value; }
        }
        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }
        public bool Anonymous
        {
            get { return _anonymous; }
            set { _anonymous = value; }
        }
        public bool ReceiptSent
        {
            get { return _receiptSent; }
            set { _receiptSent = value; }
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

        public Donations()
        {
        }

        public bool Load(int id)
        {

            string cmdText = @"SELECT * FROM Donations WHERE ID = @0";

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText, id);

            if (ds.Tables[0].Rows.Count < 1)
                return false;

            DataRow dr = ds.Tables[0].Rows[0];
            _id = Convert.ToInt32(dr["ID"]);
            _donorId = Convert.ToInt32(dr["DonorID"]);
            _amount = Convert.ToDouble(dr["Amount"]);
            _fundId = Convert.ToInt32(dr["FundID"]);
            _donationDate = Convert.ToDateTime(dr["DonationDate"]);
            _anonymous = Convert.ToBoolean(dr["Anonymous"]);
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

            string cmdText = @"SELECT " + strLimit + @" d1.*, d2.FullName as DonorName,
                                f.Name as FundName, d2.Email as DonorEmail,
                                CAST(d1.DonationDate as Date) as CDonationDate, 'datacell' as TRClass      
						        FROM Donations d1, Donors d2, Fund f
                                WHERE d1.DonorID = d2.ID 
                                    AND d1.FundID = f.ID 
                            ";

            if (whereClause != string.Empty)
            {
                cmdText = cmdText + " AND " + whereClause;
            }
            if (orderBy != string.Empty)
            {
                cmdText = cmdText + " " + orderBy;
            }

            CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdText, "SQL RAN TO GET DONATOINS....");

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText);
            return ds;
        }

        public DataSet FindDonationsByFund(string whereClause, string orderBy)
        {
            string defOrderBy = " ORDER BY SumOfAmount DESC";

            string cmdText = @"
                            SELECT Donations.FundID, 
                            CAST (Sum(Donations.Amount) AS NUMERIC(10,2)) AS SumOfAmount,
                            Fund.Name as FundName,
                            'datacell' as TRClass,
                            '1' as SectionID
                            FROM Donations INNER JOIN Fund ON Donations.FundID = Fund.ID
                            WHERE " + whereClause + @" 
                            GROUP BY Donations.FundID, Fund.Name
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

            CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdText, "SQL RAN TO GET DONATOINS by FUND");

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText);
            return ds;
        }


        public DataSet FindDonationsByDonors(string whereClause, string orderBy)
        {
            string defOrderBy = " ORDER BY SumOfAmount DESC";

            string cmdText = @"
                            SELECT Donations.DonorID, 
                            CAST (Sum(Donations.Amount) AS NUMERIC(10,2)) AS SumOfAmount, ReceiptSentDate,
                            Donors.FullName as DonorName,Donors.Email as DonorEmail, 'datacell' as TRClass
                            FROM Donors INNER JOIN Donations ON Donors.ID = Donations.DonorID
                            WHERE " + whereClause + @"
                            GROUP BY Donations.DonorID, Donors.FullName, Donors.Email, ReceiptSentDate

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

            CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdText, "SQL RAN TO GET DONATOINS by donors");

            DataSet ds = SqlHelper.ExecuteDataset(AppSetting.GetConnString(), cmdText);
            return ds;
        }

        // New function with parent - child relations...
        public DataSet GetDonationsByDonors(string whereClause, string orderBy)
        {
            string defOrderBy = " ORDER BY SumOfAmount DESC";

            // Add the sorting ORDER BY clause 
            if (whereClause != string.Empty)
            {
                whereClause = " AND " + whereClause;
            }

            SqlConnection objConn = new SqlConnection(AppSetting.GetConnString());
            DataSet objDS = new DataSet();
            string cmdTextParent = @"
                            SELECT Donations.DonorID, 
                            CAST (Sum(Donations.Amount) AS NUMERIC(10,2)) AS SumOfAmount, ReceiptSentDate,
                            Donors.FullName as DonorName,Donors.Email as DonorEmail, 'datacell' as TRClass
                            FROM Donors, Donations 
                            WHERE Donors.ID = Donations.DonorID " + whereClause + @"
                            GROUP BY Donations.DonorID, Donors.FullName, Donors.Email, ReceiptSentDate 
                            ";
            // Add the sorting ORDER BY clause 
            if (orderBy != string.Empty)
            {
                cmdTextParent = cmdTextParent + " " + orderBy;
            }
            else
            {
                cmdTextParent = cmdTextParent + " " + defOrderBy;
            }

            SqlDataAdapter daParent = new SqlDataAdapter(cmdTextParent, objConn);
            string cmdTextChild = @"
                                    SELECT Donations.DonorID,Donations.DonationDate, 
                                    CAST (Donations.Amount AS NUMERIC(10,2)) AS DonationAmount, 
                                    FUND.Name AS FundName, Donors.FullName as DonorName,
                                    Donors.Email as DonorEmail, 'datacell' as TRClass
                                    FROM Donors, Donations, Fund 
                                    WHERE Donors.ID = Donations.DonorID AND 
                                          Donations.FundID = Fund.ID " + whereClause + @"
                                    ORDER BY DonorName, Donations.DonationDate ASC 
                                    ";
            CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdTextChild, "BESTOWER - cmdTextChild");
            CIS.Lib.Utils.Utility.WriteLog(string.Empty, cmdTextParent, "BESTOWER - cmdTextParent");


            SqlDataAdapter daChild = new SqlDataAdapter(cmdTextChild, objConn);
            daParent.Fill(objDS, "parent");
            daChild.Fill(objDS, "child");
            objConn.Close();
            objDS.Relations.Add("MyRelation", objDS.Tables["parent"].Columns["DonorID"], objDS.Tables["child"].Columns["DonorID"]);
            return objDS;
        }


        public int Insert(int donorId, double amount, int fundId, DateTime donationDate, string displayName, bool anonymous, string purpose, string comments, int treeId, int organizationId)
        {
            string cmdText = @"INSERT INTO Donations (DonorID, Amount, FundID, DonationDate, DisplayName, Anonymous, Purpose, Comments, TreeID, OrganizationID) 
							VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9)";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, donorId, amount, fundId, donationDate, displayName, anonymous, purpose, comments, treeId, organizationId);

            return rowsAffected;
        }

        public int Update(int id, int donorId, double amount, int fundId, DateTime donationDate, string displayName, bool anonymous, string purpose, string comments, int treeId, int organizationId)
        {
            string cmdText = @"UPDATE Donations SET DonorID=@0, Amount=@1, FundID=@2, DonationDate=@3, DisplayName=@4, Anonymous=@5, Purpose=@6, Comments=@7, TreeID=@8, OrganizationID = @9 WHERE ID=@10";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, donorId, amount, fundId, donationDate, displayName, anonymous, purpose, comments, treeId, organizationId, id);
            return rowsAffected;
        }

        public int UpdateReceiptSentDate(int donorId, DateTime receiptSentDate, bool receiptSent, string whereClause)
        {
            string cmdText = @"UPDATE Donations SET ReceiptSentDate=@0, ReceiptSent=@1 WHERE DonorID=@2 ";

            // Add the sorting ORDER BY clause 
            if (whereClause != string.Empty)
            {
                cmdText = cmdText + " AND " + whereClause;
            }

            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, receiptSentDate, receiptSent, donorId);
            return rowsAffected;
        }
        public int Delete(int id)
        {
            string cmdText = @"DELETE FROM Donations WHERE ID=@0";
            int rowsAffected = SqlHelper.ExecuteNonQuery(AppSetting.GetConnString(), cmdText, id);
            return rowsAffected;

        }

    }
}
