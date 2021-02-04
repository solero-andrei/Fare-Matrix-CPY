using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class Recovery
    {
        static string recoveryCode = CodeGenerator.IDInformation();

        public void SendCode(string recipient)
        {
            UserModel user = new UserModel { Email = recipient };
            EmailProcessor email = new EmailProcessor { Email = recipient };

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

    }
}
