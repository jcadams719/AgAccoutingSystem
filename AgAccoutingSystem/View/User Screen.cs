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
            // TODO: This line of code loads data into the 'agDatabase.ACCOUNTS' table. You can move, or remove it, as needed.
            this.aCCOUNTSTableAdapter1.Fill(this.agDatabase.ACCOUNTS);
            // TODO: This line of code loads data into the 'gROUP4DataSet.REGISTER' table. You can move, or remove it, as needed.
            this.rEGISTERTableAdapter.Fill(this.gROUP4DataSet.REGISTER);
            

        }
        public void getUser(string userName)
        {
            userID = userName;
        }
        private void GetTransactionBttn_Click(object sender, EventArgs e)
        {
            //int accountNum = (int)aCCOUNTSDataGridView.SelectedCells[0].Value;
            Query query = new Query();
            
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
            this.Hide();
        }
    }
}
