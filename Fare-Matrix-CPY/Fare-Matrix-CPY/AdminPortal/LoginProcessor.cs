using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class LoginProcessor
    {
        string query = "";

        public LoginProcessor(string forquery)
        {
            query = forquery;
        }

        public void Accounts()//Process the account if valid
        {
            try
            {
                DataAccess data = new DataAccess { query = this.query};
                if (data.DataRetrieval() == true)
                {
                    MessageBox.Show("Login Successfully!", "Welcome to MRT Fare Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Account not found. Please try again", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
