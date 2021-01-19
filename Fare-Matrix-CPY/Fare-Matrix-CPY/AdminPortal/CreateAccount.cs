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

            List<Control> controls = mainPanel.Controls.OfType<Control>().ToList();
            foreach (var control in controls)
            {
                transition.HideSync(control);
            }

            System.Threading.Thread.Sleep(300);
            EnterEmail email = new EnterEmail();
            mainPanel.Controls.Add(email);
            email.Show();
        }
    }
}
