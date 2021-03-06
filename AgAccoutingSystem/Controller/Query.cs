using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgAccoutingSystem
{
    class Query
    {

        //LEFT JOIN ACCOUNTS ON REGISTER.ACCOUNTID = ACCOUNTS.ACCOUNTID
        //+" AND REGISTER.PENDING = 0"
        private string connString = "Data Source=BB-Enterprise.users.campus;Initial Catalog=GROUP4;Persist Security Info=True;User ID=Group4;Password=Grp4s2117";
        public DataTable getTransaction(int accountID)
        {
            string getTrans = "SELECT * FROM REGISTER WHERE ACCOUNTID = "+ accountID + " AND PENDING = 0";
            DataTable transactions = new DataTable();
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(getTrans, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        transactions.Load(reader);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }


            return transactions;
        }

        public DataTable getTransaction()
        {
            string getTrans = "SELECT * FROM REGISTER WHERE PENDING = 1";
            DataTable transactions = new DataTable();
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(getTrans, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        transactions.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }


            return transactions;
        }

        public DataTable getAccounts(string userID)
        {
            string getAccts = "SELECT ACCOUNTS.ACCOUNTID, ACCOUNTS.RESEARCHCENTER, ACCOUNTS.TYPE, ACCOUNTS.BALANCE FROM ACCOUNTS INNER JOIN USERACCOUNTS ON ACCOUNTS.ACCOUNTID = USERACCOUNTS.ACCOUNTID WHERE USERACCOUNTS.USERID = '" + userID +"'";
            DataTable accounts = new DataTable();
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(getAccts, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        accounts.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }
            return accounts;
        }

        public DataTable getAllAccounts()
        {
            string getAllAccts = "SELECT * FROM ACCOUNTS";
            DataTable allAccounts = new DataTable();
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(getAllAccts, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        allAccounts.Load(reader);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }

            return allAccounts;
        }

        public void submitTransaction(string[] arr)
        {
            int code = Int32.Parse(arr[1]);
            int accountID = Int32.Parse(arr[2]);
            string date = arr[3];
            string document = arr[4];
            string subbAcct = arr[5];
            string vendor = arr[6];
            string item = arr[7];
            int deposit = Int32.Parse(arr[8]);
            int expense = Int32.Parse(arr[9]);
            int year = Int32.Parse(arr[10]);
            string status = arr[11];
            string comment = arr[12];

            string sqlCMD = "INSERT INTO REGISTER (CODE, ACCOUNTID, DATE, DOCUMENT, SUBACCT, VENDOR, ITEM, DEPOSIT, EXPENSE, FISCALYEAR, STATUS, COMMENT, PENDING) VALUES (" + code + "," + accountID + ",'" + date + "', '" + document + "','" + subbAcct + "','" + vendor + "','" + item + "'," + deposit + "," + expense + "," + year + ",'" + status + "','" + comment + "', 1)";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlCMD, myConnection))
                    {
                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }
        }


        public void confirmTransaction(string[] arr)
        {
            int transactionID = Int32.Parse(arr[0]);
            int code = Int32.Parse(arr[1]);
            int accountID = Int32.Parse(arr[2]);
            string date = arr[3];
            string document = arr[4];
            string subbAcct = arr[5];
            string vendor = arr[6];
            string item = arr[7];
            int deposit = Int32.Parse(arr[8]);
            int expense = Int32.Parse(arr[9]);
            int year = Int32.Parse(arr[10]);
            string status = arr[11];
            string comment = arr[12];

            string sqlCMD = "UPDATE REGISTER SET CODE = " + code + ", ACCOUNTID = " + accountID + ", DATE = '" + date + "', DOCUMENT = '" + document + "', SUBACCT = '" + subbAcct + "', VENDOR = '" + vendor + "', ITEM = '" + item + "', DEPOSIT = " + deposit + ", EXPENSE = " + expense + ", FISCALYEAR = " + year + ", STATUS = '" + status + "', COMMENT = '" + comment + "', PENDING = 0 WHERE TRANSACTIONID = " + transactionID;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlCMD, myConnection))
                    {
                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }
        }


        public DataTable userDiscipline()
        {
            string sqlCMD = "SELECT USERID, NAME, DISCIPLINE FROM USERS";
            DataTable userDiscipline = new DataTable();
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlCMD, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        userDiscipline.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }
            return userDiscipline;
        }

        public void changeDiscipline(string[] arr)
        {
            string userID = arr[0];
            string name = arr[1];
            string discipline = arr[2];


            //woops sorry boys
            string sqlCMD = "UPDATE USERS SET DISCIPLINE = '" + discipline +"' WHERE USERID = '" + userID + "'";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlCMD, myConnection))
                    {
                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }

        }

        public void deleteSubmission(int transID)
        {
            string sqlCMD = "DELETE FROM REGISTER WHERE TRANSACTIONID = " + transID;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlCMD, myConnection))
                    {
                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }

        }

        public void enterAccount(string[] variable)
        {
            string sqlCMD = "INSERT INTO ACCOUNTS (ACCOUNTID, RESEARCHCENTER, TYPE, BALANCE) VALUES (" + Int32.Parse(variable[0]) + ", '" + variable[1] + "','" + variable[2] + "', " + Int32.Parse(variable[3])+")";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlCMD, myConnection))
                    {
                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }

        }

    }
}
