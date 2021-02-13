using Fare_Matrix_CPY.Admin_Portal;
using Fare_Matrix_CPY.AdminPortal.Forms;
using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fare_Matrix_CPY.AdminPortal
{
    public partial class ForgotPassword : Form
    {

        private Login login;

        public ForgotPassword(Login frm)
        {
            InitializeComponent();

            login = frm;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Recovery recovery = new Recovery();
            Recovery.Recipient = txtRecipient.Text;
            recovery.SendCode();

            recoveryCode1.Visible = true;
            recoveryCode1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            login.Opacity = 1;
            Dispose();
        }
    }
}
