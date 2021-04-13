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
    }
}
