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
    public partial class ViewSubmissions : Form
    {
        private string UserID;
        public ViewSubmissions()
        {
            InitializeComponent();
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            var acctScreen = new Accountant_Screen();
            acctScreen.Show();
            this.Hide();
        }
        public void getID(string userID)
        {
            UserID = userID;
        }

        private void ViewSubmissions_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            query.getTransaction();
            TransactionsdataGridView.DataSource = query.getTransaction();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmBttn_Click(object sender, EventArgs e)
        {

            string[] variables = new string[13];
            int index = (int)TransactionsdataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = TransactionsdataGridView.Rows[index];
            variables[0] = selectedRow.Cells["TRANSACTIONID"].Value.ToString().Trim();
            variables[1] = selectedRow.Cells["CODE"].Value.ToString().Trim();
            variables[2] = selectedRow.Cells["ACCOUNTID"].Value.ToString().Trim();
            DateTime date = Convert.ToDateTime(TransactionsdataGridView.CurrentRow.Cells["DATE"].Value);
            variables[3] = date.ToString("yyyy-MM-dd");
            variables[4] = selectedRow.Cells["DOCUMENT"].Value.ToString().Trim();
            variables[5] = selectedRow.Cells["SUBACCT"].Value.ToString().Trim();
            variables[6] = selectedRow.Cells["VENDOR"].Value.ToString().Trim();
            variables[7] = selectedRow.Cells["ITEM"].Value.ToString().Trim();
            variables[8] = selectedRow.Cells["DEPOSIT"].Value.ToString().Trim();
            variables[9] = selectedRow.Cells["EXPENSE"].Value.ToString().Trim();
            variables[10] = selectedRow.Cells["FISCALYEAR"].Value.ToString().Trim();
            variables[11] = selectedRow.Cells["STATUS"].Value.ToString().Trim();
            variables[12] = selectedRow.Cells["COMMENT"].Value.ToString().Trim();

            Query query = new Query();
            query.confirmTransaction(variables);

            var newView = new ViewSubmissions();
            newView.Show();
            this.Hide();
        }

        private void RejectBttn_Click(object sender, EventArgs e)
        {
            int index = (int)TransactionsdataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = TransactionsdataGridView.Rows[index];
            int transID = (int)selectedRow.Cells["TRANSACTIONID"].Value;
            Query query = new Query();
            query.deleteSubmission(transID);

            var newView = new ViewSubmissions();
            newView.Show();
            this.Hide();
        }
    }
}
