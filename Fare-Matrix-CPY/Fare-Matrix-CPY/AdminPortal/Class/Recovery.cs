using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class Recovery : UserModel
    {
        static string recoveryCode = CodeGenerator.IDInformation();
        public static string Recipient { get; set; }

        public void SendCode()
        {
            EmailProcessor email = new EmailProcessor { Email = Recipient };

            email.Send("Fare matrix account recovery.",
                $"Hello, Good Day.\nThis is your recovery code for your account : {recoveryCode} \n\n\n-Fare matrix developer");
        }
        
        public static bool CheckCode(string code)
        {
            bool IsValid = false;

            if (code == recoveryCode)
                IsValid = true;

            return IsValid;
        }

        public void SaveNewPassword(string newPassword)
        {
            string tableName = "UsersAccount";
            string attribute = "_Password";
            string value = newPassword;
            string condition = $"WHERE [Email] = '{Recipient}'";

            UserService service = new UserService();
            service.UpdateUser(tableName, attribute, value, condition);

        }

    }
}
