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
    public partial class SubmissionFrm : Form
    {
        private string UserID;

        public SubmissionFrm()
        {
            InitializeComponent();
        }
        public void getID(string userID)
        {
            UserID = userID;
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            var userScreen = new User_Screen();
            userScreen.getUser(UserID);
            userScreen.Show();
            this.Hide();
        }

        private void SubmitBttn_Click(object sender, EventArgs e)
        {

        }

        private void SubmissionFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
