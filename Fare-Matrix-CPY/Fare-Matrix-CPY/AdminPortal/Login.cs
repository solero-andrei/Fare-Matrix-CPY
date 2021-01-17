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

namespace Fare_Matrix_CPY.Admin_Portal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            Hide();
            CreateAccount signup = new CreateAccount();
            System.Threading.Thread.Sleep(300);
            signup.ShowDialog();
        }
    }
}
