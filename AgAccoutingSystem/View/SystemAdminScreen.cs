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
    public partial class System_Admin_Screen : Form
    {
        private string userID;
        public System_Admin_Screen()
        {
            InitializeComponent();
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            var signIn = new SignInFrm();
            signIn.Show();
            this.Hide();
        }

        private void System_Admin_Screen_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            adminAllAccountsDataGrid.DataSource = query.getAllAccounts();

            Query query2 = new Query();
            DisciplineDataGrid.DataSource = query2.userDiscipline();
        }

        public void getUserID(string UserID)
        {
            userID = UserID;
        }

        private void adminViewSubmissionButton_Click(object sender, EventArgs e)
        {
            int accountNum = (int)adminAllAccountsDataGrid.SelectedCells[0].Value;
            Query query = new Query();
            adminViewTransactionsDataGrid.DataSource = query.getTransaction(accountNum);
        }

        private void ChangeBttn_Click(object sender, EventArgs e)
        {

            if(UserRB.Checked || AccountantRB.Checked || SysAdminRB.Checked)
            {
                string[] variables = new string[5];
                int index = (int)DisciplineDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DisciplineDataGrid.Rows[index];
                variables[0] = selectedRow.Cells["USERID"].Value.ToString().Trim();
                variables[1] = selectedRow.Cells["NAME"].Value.ToString().Trim();

                if (SysAdminRB.Checked)
                {
                    variables[2] = SysAdminRB.Text;
                }
                else if (UserRB.Checked)
                {
                    variables[2] = UserRB.Text;
                }
                else if (AccountantRB.Checked)
                {
                    variables[2] = AccountantRB.Text;
                }


                Query query = new Query();
                query.changeDiscipline(variables);

                var newView = new System_Admin_Screen();
                newView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a button.");
            }
            
        }
    }
}
