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
    }
}
