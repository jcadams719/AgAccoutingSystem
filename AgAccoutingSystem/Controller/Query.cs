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
            string getTrans = "SELECT * FROM REGISTER LEFT JOIN ACCOUNTS ON REGISTER.ACCOUNTID = ACCOUNTS.ACCOUNTID WHERE ACCOUNTS.ACCOUNTID = "+ accountID +"";
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
    }
}
