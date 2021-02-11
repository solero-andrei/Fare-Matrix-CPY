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
    public partial class DashboardSettings : UserControl
    {
        public DashboardSettings()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ChangeProfile profile = new ChangeProfile();
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
    }
}
