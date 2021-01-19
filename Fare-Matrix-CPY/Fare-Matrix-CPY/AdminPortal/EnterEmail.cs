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
    public partial class EnterEmail : UserControl
    {
        public EnterEmail()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(300);
            //MessageBox.Show("Account created successfully!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SavingAccountPrompt frm = new SavingAccountPrompt();
            frm.Show();
        }
    }
}
