using Fare_Matrix_CPY.AdminPortal.Forms;
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
    public partial class CardsInformation : Form
    {
        private Dashboard admin;

        public CardsInformation(Dashboard frm)
        {
            InitializeComponent();

            admin = frm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            admin.Opacity = 1;
        }
    }
}
