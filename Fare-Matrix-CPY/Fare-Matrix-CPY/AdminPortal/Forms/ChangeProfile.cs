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
    public partial class ChangeProfile : UserControl
    {
        public ChangeProfile()
        {
            InitializeComponent();
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
    }
}
