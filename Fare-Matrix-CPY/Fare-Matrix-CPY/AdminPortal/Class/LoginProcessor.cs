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
        public bool Account(string username, string password)
        {
            bool IsAccountValid = false;
            UserService service = new UserService();
            var isvalid = service.GetUserByAccount(username, password);

            if(isvalid == true)
            {
                IsAccountValid = true;
            }

            return IsAccountValid;
        }
    }
}
