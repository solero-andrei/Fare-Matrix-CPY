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

namespace Fare_Matrix_CPY.AdminPortal
{
    public partial class DashboardSettings : UserControl
    {

        private Dashboard admin;

        public DashboardSettings(Dashboard frm)
        {
            InitializeComponent();
            admin = frm;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ChangeProfile profile = new ChangeProfile(admin);
            OpenConfiguration(profile);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            
        }

        public void OpenConfiguration(Control frm)
        {
            bodyPanel.Controls.Clear();

            bodyPanel.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
