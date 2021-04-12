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
        public User_Screen()
        {
            InitializeComponent();
        }

        private void User_Screen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP4DataSet.REGISTER' table. You can move, or remove it, as needed.
            this.rEGISTERTableAdapter.Fill(this.gROUP4DataSet.REGISTER);
            // TODO: This line of code loads data into the 'gROUP4DataSet.ACCOUNTS' table. You can move, or remove it, as needed.
            this.aCCOUNTSTableAdapter.Fill(this.gROUP4DataSet.ACCOUNTS);

        }

        private void GetTransactionBttn_Click(object sender, EventArgs e)
        {

        }

        private void GetAccountsBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
