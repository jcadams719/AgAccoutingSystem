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
    public partial class SignInFrm : Form
    {
        public SignInFrm()
        {
            InitializeComponent();
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //SubmitCredentials Method in Class Diagram
        private void SignInBttn_Click(object sender, EventArgs e)
        {
            string userName = UsernameTB.Text;
            string passWord = PasswordTB.Text;
            Login_Query login_Query = new Login_Query();
            if(login_Query.login(userName, passWord))
            {
                string[] info = login_Query.getUserInfo(userName);
                Users user = new Users();
                user.UserID = info[0];
                user.Permissions = info[1];
                user.Discipline = info[2];
                if(user.Discipline == "Accountant")
                {
                    var accountant = new Accountant_Screen();
                    accountant.Show();
                    this.Hide();
                }
                else if(user.Discipline == "User")
                {
                    var userScreen = new User_Screen();
                    userScreen.getUser(user.UserID);
                    userScreen.Show();
                    this.Hide();
                }
                else if(user.Discipline == "Administrator")
                {
                    var adminScreen = new System_Admin_Screen();
                    adminScreen.Show();
                    this.Hide();
                }
                
            }
        }
    }
}
