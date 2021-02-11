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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool x = showPassword.Checked ? txtPassword.isPassword = false : txtPassword.isPassword = true;
        }
    }
}
