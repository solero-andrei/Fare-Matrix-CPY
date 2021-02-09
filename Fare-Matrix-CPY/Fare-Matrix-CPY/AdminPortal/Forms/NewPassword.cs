using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fare_Matrix_CPY.Admin_Portal;

namespace Fare_Matrix_CPY.AdminPortal
{ 
    public partial class NewPassword : UserControl
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            Task<bool> saving = new Task<bool>(SavePassword);
            saving.Start();

            lblSaving.Visible = true;
            bool savingAccount = await saving;

            if (savingAccount == true)
            {
                MessageBox.Show("Successfully updated your password.", "Please login your account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login loginform = new Login();
                loginform.Opacity = 1;
                loginform.Show();
                ((Form)this.TopLevelControl).Close();
            }
            else
            {
                MessageBox.Show("Password and confirm password is unmatch.\nPlease try again", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public bool SavePassword()
        {
            bool IsValid = false;
            if (txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {
                Recovery recover = new Recovery();
                recover.SaveNewPassword(txtNewPassword.Text);
                IsValid = true;
            }

            return IsValid;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
