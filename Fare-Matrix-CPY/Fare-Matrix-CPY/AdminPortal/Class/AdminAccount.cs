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
        string UserID = IDNumberGenerator.IDInformation();
        int AccountID = IDNumberGenerator.Account();

        public void Save(string userinformation, string useraccount)
        {
            UserService service = new UserService
            {
                UserInformation = $"'{UserID}', {userinformation}, 1",
                UserAccount = $"{AccountID}, '{UserID}', {useraccount}, '{DateTime.Today}'"
            };

            service.AddUser();
        }
        

        public void SaveImage(System.Windows.Forms.PictureBox pb)
        {
            pb.Image.Save($@"UserImages\{UserID}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        
    }
}
