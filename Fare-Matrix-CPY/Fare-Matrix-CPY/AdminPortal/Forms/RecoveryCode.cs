using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fare_Matrix_CPY.AdminPortal.Forms
{
    public partial class RecoveryCode : UserControl
    {
        public RecoveryCode()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var IsValid = Recovery.CheckCode(txtCode.Text);

            if (IsValid == true)
            {
                newPassword1.Visible = true;
                newPassword1.Show();
            }
            else
                MessageBox.Show("Recovery is not match.\nPlease try again", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
