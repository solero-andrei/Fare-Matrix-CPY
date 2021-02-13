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
using Fare_Matrix_CPY.AdminPortal.Forms;
using Fare_Matrix_CPY.AdminPortal;


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
            LoginAccount();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLinkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opacity = .7;
            ForgotPassword recover = new ForgotPassword(this);
            recover.ShowDialog();
        }

        public void LoginAccount()
        {
            LoginProcessor login = new LoginProcessor();
                                   
            var check = login.Account(txtEmail.Text, txtPassword.Text);
            if (check == true)
            {
                MessageBox.Show("Successfully Login, Welcome Admin", "Login successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Hide();
                System.Threading.Thread.Sleep(500);
                Dashboard admin = new Dashboard(login.Name, login.ID);
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Account not found, please try again", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
