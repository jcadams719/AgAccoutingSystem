using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgAccoutingSystem
{
    public partial class User_Screen : Form
    {
        private string userID;
        public User_Screen()
        {
            InitializeComponent();
        }

        private void User_Screen_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            aCCOUNTSDataGridView.DataSource = query.getAccounts(userID);
        }
        public void getUser(string userName)
        {
            userID = userName;
        }
        private void GetTransactionBttn_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNum = (int)aCCOUNTSDataGridView.SelectedCells[0].Value;
                Query query = new Query();
                TransactionDataGridView.DataSource = query.getTransaction(accountNum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must select ACCOUNTID to view transactions.");
            }
        }

        private void GetAccountsBttn_Click(object sender, EventArgs e)
        {

        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            var signIn = new SignInFrm();
            signIn.Show();
            this.Hide();
        }

        private void SubmitTransBttn_Click(object sender, EventArgs e)
        {
            var submissionFrm = new SubmissionFrm();
            submissionFrm.Show();
            submissionFrm.getID(userID);
            this.Hide();
        }
    }
}
