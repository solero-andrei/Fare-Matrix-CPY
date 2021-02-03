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
    public partial class SavingAccountPrompt : Form
    {
        public SavingAccountPrompt()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loading.percentage == 100)
            {
                timer1.Stop();
                MessageBox.Show("Your account is successfully saved!", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
                loading.percentage += 2;
        }
    }
}
