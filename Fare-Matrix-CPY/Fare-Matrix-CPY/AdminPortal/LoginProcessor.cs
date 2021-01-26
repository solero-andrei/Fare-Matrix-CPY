using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class LoginProcessor
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public bool Accounts()//Process the account if valid
        {
            bool IsValid = false;
            DataAccess data = new DataAccess { query = $"SELECT * FROM {Role}Account WHERE [Email] = '{Email}' AND [_Password] = '{Password}'" };

            if (data.DataRetrieval() == true)
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
            }

            return IsValid;
        }
    }
}
