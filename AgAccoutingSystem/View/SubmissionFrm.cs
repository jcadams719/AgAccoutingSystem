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
            string[] submissionArr = new string[13];
            submissionArr[1] = CodeTxt.Text;
            submissionArr[2] = AccountIDTxt.Text;
            submissionArr[3] = DateTxt.Text;
            submissionArr[4] = DocumentTxt.Text;
            submissionArr[5] = SubAcctTxt.Text;
            submissionArr[6] = VendorTxt.Text;
            submissionArr[7] = ItemTxt.Text;
            if(DepositTxt.Text != "")
            {
                submissionArr[8] = DepositTxt.Text;
            }
            else
            {
                submissionArr[8] = "0";
            }
            if (ExpenseTxt.Text != "")
            {
                submissionArr[9] = ExpenseTxt.Text;
            }
            else
            {
                submissionArr[9] = "0";
            }
            submissionArr[10] = YearTxt.Text;
            submissionArr[11] = StatusTxt.Text;
            submissionArr[12] = CommentTxt.Text;

            Query query = new Query();
            query.submitTransaction(submissionArr);

            var originalUserScreen = new User_Screen();
            originalUserScreen.getUser(UserID);
            originalUserScreen.Show();
            this.Hide();

        }

        private void SubmissionFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
