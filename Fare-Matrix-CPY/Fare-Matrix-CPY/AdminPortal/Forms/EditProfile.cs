using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fare_Matrix_CPY.AdminPortal
{
    public partial class EditProfile : UserControl
    {
        public EditProfile()
        {
            InitializeComponent();

            LoadProfile profile = new LoadProfile();
            txtFirstName.Text = profile.FirstName;
            txtMiddleName.Text = profile.MiddleName;
            txtLastName.Text = profile.Lastname;
            txtEmail.Text = profile.Email;
            txtPassword.Text = profile.Password;
            txtConfirmPassword.Text = txtPassword.Text;
            txtUsername.Text = profile.Username;
            lblUserID.Text = profile.UserID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool x = showPassword.Checked ? txtPassword.isPassword = false : txtPassword.isPassword = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateInformation();
            MessageBox.Show("Data updated successfully", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        public void UpdateInformation()
        {
            DataEditor edit = new DataEditor
            {
                UserID = lblUserID.Text, FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text, Lastname = txtLastName.Text,
                Email = txtEmail.Text, Password = txtPassword.Text,
                Username = txtUsername.Text
            };

            edit.UserData();

        }

    }
}
