using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class LoadProfile : UserModel
    {
        public static string email { get; set; }
        public static string password { get; set; }

        public LoadProfile()
        {
            ExistingByAccount();
        }

        public void ExistingByAccount()
        {
            UserService service = new UserService();
            service.GetUserByAccount(email, password);

            UserID = service.UserID;
            FirstName = service.FirstName;
            MiddleName = service.MiddleName;
            Lastname = service.Lastname;
            Email = service.Email;
            Password = service.Password;
            Username = service.Username;
            AccountID = service.AccountID;
        }
    }
}
