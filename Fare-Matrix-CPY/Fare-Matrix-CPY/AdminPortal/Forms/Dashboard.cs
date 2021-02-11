using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fare_Matrix_CPY.AdminPortal.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard(string Name, string ID)
        {
            InitializeComponent();
            lblName.Text = Name;
            lblID.Text = ID.ToString();

            pbxUserProfile.Image = Image.FromFile($"UserImages\\{ID}.jpg");
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString().ToString();
            lblTime.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            DashboardSettings settings = new DashboardSettings();
            System.Threading.Thread.Sleep(300);
            bodyPanel.Controls.Add(settings);
            settings.Show();
            settings.BringToFront();
        }
    }
}
