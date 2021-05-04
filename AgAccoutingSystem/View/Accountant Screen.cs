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
            int accountNum = (int)allAccountsDataGrid.SelectedCells[0].Value;
            Query query = new Query();
            accountantViewTransactionsDataGrid.DataSource = query.getTransaction(accountNum);
        }
    }
}
