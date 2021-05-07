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
    public partial class Accountant_Screen : Form
    {

        private string userID;
        public Accountant_Screen()
        {
            InitializeComponent();
        }

        public void getUser(string UserID)
        {
            userID = UserID;
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            var login = new SignInFrm();
            login.Show();
            this.Hide();
        }

        // *VIEW SUBMISSIONS CLICK*
        private void button1_Click(object sender, EventArgs e)
        {
            var viewSub = new ViewSubmissions();
            viewSub.getID(userID);
            viewSub.Show();
            this.Hide();
        }

        private void Accountant_Screen_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            allAccountsDataGrid.DataSource = query.getAllAccounts();
        }

        private void ViewTransactionsBttn_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNum = (int)allAccountsDataGrid.SelectedCells[0].Value;
                Query query = new Query();
                accountantViewTransactionsDataGrid.DataSource = query.getTransaction(accountNum);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Must select ACCOUNTID to view transactions.");
            }
        }

        private void AddAcctBttn_Click(object sender, EventArgs e)
        {
            string[] variables = new string[4];
            int index = (int)allAccountsDataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = allAccountsDataGrid.Rows[index];

            variables[0] = selectedRow.Cells["ACCOUNTID"].Value.ToString().Trim();
            variables[1] = selectedRow.Cells["RESEARCHCENTER"].Value.ToString().Trim();
            variables[2] = selectedRow.Cells["TYPE"].Value.ToString().Trim();
            variables[3] = selectedRow.Cells["BALANCE"].Value.ToString().Trim();

            try
            {
                Query query = new Query();
                query.enterAccount(variables);

                var newView = new Accountant_Screen();
                newView.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select an account not already in the database.");
            }
            
        }
    }
}
