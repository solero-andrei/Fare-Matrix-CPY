using Fare_Matrix_CPY.Admin_Portal;
using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public partial class CreateAccount : Form
    {

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            Task<bool> saving = new Task<bool>(SaveAdminAccount);
            saving.Start();

            lblProcessor.Visible = true;
            bool WillSaveAccount = await saving;
            if(WillSaveAccount == true)
            {
                SavingAccountPrompt save = new SavingAccountPrompt();
                save.ShowDialog();
                var login = MessageBox.Show("Do you want to login your account now?", "Login your account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(login == DialogResult.Yes)
                {
                    Opacity = 70;
                    Dispose();
                    Login loginform = new Login();
                    loginform.Show();
                }
            }
            else
            {
                MessageBox.Show("Error occured while saving your account.\nPlease check all the fields.", "Error saving", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblProcessor.Visible = false;
            }

        }

        public bool SaveAdminAccount()
        {
            bool WillSave = false;
            ValidateSave validate = new ValidateSave
            {
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Lastname = txtLastName.Text,
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                ConfirmPassword = txtConfirmPassword.Text,
                image = pbxUserImage
            };

            System.Threading.Thread.Sleep(1000);

            var IsValidAccount = validate.ValidateAccount();
            if(IsValidAccount == true)
            {
                WillSave = true;
            }

            return WillSave;
        }
        
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxUserImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            Login adminLogin = new Login();
            adminLogin.Show();
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (!txtConfirmPassword.Text.Equals(txtPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "The password and confirm password is unmatch");   
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
