using Fare_Matrix_CPY.AdminPortal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FareMatrixLibrary;

namespace Fare_Matrix_CPY.Admin_Portal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGoogle_Click_1(object sender, EventArgs e)
        {
            Hide();
            CreateAccount signup = new CreateAccount();
            System.Threading.Thread.Sleep(300);
            signup.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProcessLogin();
        }

        public void ProcessLogin()
        {
            LoginProcessor proccessor = new LoginProcessor { Email = txtEmail.Text, Password = txtPassword.Text, Role = "Admin" };
            var isValidate = proccessor.Accounts();
            if (isValidate == true)
            {
                MessageBox.Show("Successfully Login. Welcome Admin", "Welcome to MRT Fare Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Account is Invalid. Please try again", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
