using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class AdminAccount
    {
        string id = IDNumberGenerator.IDInformation();
        string path = System.Windows.Forms.Application.StartupPath + @"\Images\";

        public void SaveInformation(string lastName, string firstName, string middleName)
        {       
            UserService service = new UserService();

            string[] attribute = { "AdminNumber", "LastName", "FirstName", "MiddleName" };
            string[] value = { $"'{id}'", $"'{lastName}'", $"'{firstName}'", $"'{middleName}'" };

            service.AddUser("AdminInformation", attribute, value);
        }

        public void SaveAccount(string email, string _password, string username)
        {
            int id = IDNumberGenerator.Account();
            UserService service = new UserService();

            string[] attribute = { "AccountID", "AdminNumber", "Email", "_Password", "DateCreated", "UserName" };
            string[] value = { $"'{id}'", $"'{this.id}'", $"'{email}'", $"'{_password}'", $"'{DateTime.UtcNow}'", $"'{username}'" };

            service.AddUser("AdminAccount", attribute, value);
        }

        public void SaveImage(System.Windows.Forms.PictureBox pb)
        {
            pb.Image.Save($@"UserImages\{id}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        
    }
}
