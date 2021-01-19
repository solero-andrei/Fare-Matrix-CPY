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

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginProcessor processor = new LoginProcessor(
                $"SELECT * FROM AdminAccount WHERE [Email] = '{txtEmail.Text}' AND [_Password] = '{txtPassword.Text}'"
                );
            processor.Accounts();

        }
    }
}
