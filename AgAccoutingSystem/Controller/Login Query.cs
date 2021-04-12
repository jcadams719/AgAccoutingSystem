using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AgAccoutingSystem
{
    class Login_Query
    {
        private string connString = "Data Source=BB-Enterprise.users.campus;Initial Catalog=GROUP4;Persist Security Info=True;User ID=Group4;Password=Grp4s2117";
        public bool login(string userName, string password)
        {

            string loginQuery = "SELECT USERID, PASSWORD FROM USERS WHERE USERID = '" + userName + "' AND PASSWORD = '" + password + "'";
            bool verified = false;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand(loginQuery, myConnection);
                    SqlDataReader readerReturnValue = cmd.ExecuteReader();
                    if(readerReturnValue.HasRows == true)
                    {
                        return true;
                    }

                    myConnection.Close();
                }
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }
            return verified;
        }
        
        public string[] getUserInfo(string userName)
        {
            string getInfoQuery = "SELECT USERID, PERMISSIONS, DISCIPLINE FROM USERS WHERE USERID = '" + userName + "'";
            string[] userInfo = new string[3];
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connString))
                {
                    sqlConnection.Open();
                    using (SqlCommand infoCmd = new SqlCommand(getInfoQuery, sqlConnection))
                    {
                        using (SqlDataReader infoReader = infoCmd.ExecuteReader())
                        {
                            while (infoReader.Read())
                            {
                                string userID = infoReader["USERID"].ToString();
                                string permissions = infoReader["PERMISSIONS"].ToString();
                                string discipline = infoReader["DISCIPLINE"].ToString();
                                userInfo[0] = userID.TrimEnd();
                                userInfo[1] = permissions.TrimEnd();
                                userInfo[2] = discipline.TrimEnd();
                            }
                            infoReader.Close();
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception: " + ex.Message);
            }
            return userInfo;
        }
    }
}
