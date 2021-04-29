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
    }
}
