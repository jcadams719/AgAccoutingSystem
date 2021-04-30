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
        private string connString = "Data Source=BB-Enterprise.users.campus;Initial Catalog=GROUP4;Persist Security Info=True;User ID=Group4;Password=Grp4s2117";
        public DataTable getTransaction(int accountID)
        {
            string getTrans = "SELECT * FROM REGISTER LEFT JOIN ACCOUNTS ON REGISTER.ACCOUNTID = ACCOUNTS.ACCOUNTID WHERE ACCOUNTS.ACCOUNTID = "+ accountID +" AND REGISTER.PENDING = 0";
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
            string getTrans = "SELECT * FROM REGISTER LEFT JOIN ACCOUNTS ON REGISTER.ACCOUNTID = ACCOUNTS.ACCOUNTID WHERE REGISTER.PENDING = 1";
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
            string getAccts = "SELECT * FROM ACCOUNTS LEFT JOIN USERACCOUNTS ON ACCOUNTS.ACCOUNTID = USERACCOUNTS.ACCOUNTID WHERE USERACCOUNTS.USERID = '" + userID +"'";
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

        public static DateTime DateParse(string date)
        {
            date = date.Trim();
            if (!string.IsNullOrEmpty(date))
                return DateTime.Parse(date, new System.Globalization.CultureInfo("en-GB"));
            return new DateTime();
        }

    }
}
