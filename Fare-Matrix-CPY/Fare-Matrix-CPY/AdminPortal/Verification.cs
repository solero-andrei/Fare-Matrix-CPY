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
    public partial class Verification : UserControl
    {
        public Verification()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<Control> controls = mainPanel.Controls.OfType<Control>().ToList();
            foreach (Control ctrl in controls)
            {
                transition.HideSync(ctrl);
            }
            System.Threading.Thread.Sleep(300);
            transition.ShowSync(createAccountPassword1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
