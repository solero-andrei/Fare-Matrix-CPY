using Fare_Matrix_CPY.Admin_Portal;
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
            SavingAccountPrompt save = new SavingAccountPrompt();
            save.ShowDialog();
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
    }
}
