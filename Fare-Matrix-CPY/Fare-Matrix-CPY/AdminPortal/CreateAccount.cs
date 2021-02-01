using Fare_Matrix_CPY.Admin_Portal;
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
using System.Data.SqlClient;

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Validator validation = new Validator(txtLastName.Text, txtFirstName.Text, txtMiddleName.Text,
                txtUsername.Text, txtEmail.Text, txtPassword.Text, txtConfirmPassword.Text, pbxUserImage);
            SavingAccountPrompt prompt = new SavingAccountPrompt();
            bool canSave = validation.ValidateAccount();

            if(canSave == true)
            {
                prompt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error saving your account, please check all the fields.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        }
    }
}
