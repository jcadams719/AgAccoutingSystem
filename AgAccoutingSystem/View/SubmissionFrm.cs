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
            int i = 1;
            if (i == 1)
            {
                try
                {

                    string[] submissionArr = new string[13];

                    submissionArr[1] = CodeTxt.Text;
                    submissionArr[2] = AccountIDTxt.Text;
                    submissionArr[3] = DateTxt.Text;
                    submissionArr[4] = DocumentTxt.Text;
                    submissionArr[5] = SubAcctTxt.Text;
                    submissionArr[6] = VendorTxt.Text;
                    submissionArr[7] = ItemTxt.Text;
                    if (DepositTxt.Text != "")
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
                    i = 0;
                    MessageBox.Show("Submission recieved!");
                    CodeTxt.Text = null;
                    AccountIDTxt.Text = null;
                    DateTxt.Text = null;
                    DocumentTxt.Text = null;
                    SubAcctTxt.Text = null;
                    VendorTxt.Text = null;
                    ItemTxt.Text = null;
                    DepositTxt.Text = null;
                    ExpenseTxt.Text = null;
                    YearTxt.Text = null;
                    StatusTxt.Text = null;
                    CommentTxt.Text = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please verify all of the credentials are entered correctly.");
                    CodeTxt.Text = null;
                    AccountIDTxt.Text = null;
                    DateTxt.Text = null;
                    DocumentTxt.Text = null;
                    SubAcctTxt.Text = null;
                    VendorTxt.Text = null;
                    ItemTxt.Text = null;
                    DepositTxt.Text = null;
                    ExpenseTxt.Text = null;
                    YearTxt.Text = null;
                    StatusTxt.Text = null;
                    CommentTxt.Text = null;
                }
            }
        }

        private void SubmissionFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
