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
        public string Name { get; set; }
        public string ID { get; private set; }

        public bool Account(string username, string password)
        {
            bool IsAccountValid = false;
            UserService service = new UserService();

            LoadProfile.email = username;
            LoadProfile.password = password;

            var isvalid = service.GetUserByAccount(username, password);
            ID = service.UserID;
            Name = $"{service.Lastname}, {service.FirstName} {service.MiddleName}.";
            
            if (isvalid == true)
            {
                IsAccountValid = true;
            }

            return IsAccountValid;
        }
    }
}
