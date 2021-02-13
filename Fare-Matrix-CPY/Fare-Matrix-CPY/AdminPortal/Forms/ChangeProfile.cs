using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fare_Matrix_CPY.AdminPortal.Forms;
using Fare_Matrix_CPY.Admin_Portal;

namespace Fare_Matrix_CPY.AdminPortal
{
    public partial class ChangeProfile : UserControl
    {

        private Dashboard admin;

        public ChangeProfile(Dashboard frm)
        {
            InitializeComponent();

            admin = frm;
            LoadProfile profile = new LoadProfile();
            lblUserID.Text = profile.UserID;
            lblUsername.Text = profile.Username;
            lblEmail.Text = profile.Email;
            lblAccountID.Text = profile.AccountID;
            pbxProfilePicture.Image = Image.FromFile($"UserImages\\{profile.UserID}.jpg");
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEditProfile_Click_1(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            bodyPanel.Controls.Add(editProfile);
            editProfile.Show();
            editProfile.BringToFront();
        }

        private void btnEditProfilePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxProfilePicture.Image = null;
                pbxProfilePicture.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void lnkUpdatePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin.pbxUserProfile.Image.Dispose();
            pbxProfilePicture.Image.Dispose();
            

            DataEditor edit = new DataEditor();
            edit.ProfileImage(pbxProfilePicture, lblUserID.Text);
            MessageBox.Show("Profile photo changed.\nMust restart the application to see changes.", "Image updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeactivate_Click_1(object sender, EventArgs e)
        {
            DialogResult deactivating = MessageBox.Show("Are you sure you want to deactivate your account?\n-We will logout your account and you will not be able to login using your current account", "Deactivate Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(deactivating == DialogResult.Yes)
            {
                DataEditor edit = new DataEditor();
                edit.UserStatus(lblAccountID.Text);
                System.Threading.Thread.Sleep(300);
                MessageBox.Show("Your account is now deactivated. We will logout your account now.", "Account deactivated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                System.Threading.Thread.Sleep(700);

                ((Form)this.TopLevelControl).Close();
                Login login = new Login();
                login.Show();
            }
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
