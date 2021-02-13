using Fare_Matrix_CPY.AdminPortal.Forms;
using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class DataEditor : UserModel
    {
       
        public void ProfileImage(System.Windows.Forms.PictureBox image, string userID)
        {
            try
            {
                image.Dispose();
                if (System.IO.File.Exists($"UserImages\\{userID}.jpg"))
                {
                    System.IO.File.Delete($"UserImages\\{userID}.jpg");
                }
                image.Image.Save($"UserImages\\{userID}.jpg");

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            
        }

        public void UserData()
        {
            string informationValues = $"[FirstName] = '{FirstName}', " + 
                $"[MiddleName] = '{MiddleName}', [LastName] = '{Lastname}'";

            UserService UpdateInformation = new UserService();
            UpdateInformation.UpdateUser("Users", informationValues, $" WHERE [UserID] = '{UserID}'");

            string accountValues = $"[Username] = '{Username}', " +
                $"[Email] = '{Email}', [_Password] = '{Password}'";

            UserService UpdateAccount = new UserService();
            UpdateInformation.UpdateUser("UsersAccount", accountValues, $" WHERE [UsersID] = '{Username}'");

        }

        public void UserStatus(string userID)
        {
            string set = "[Status] = 'Deactivated'";
            UserService status = new UserService();
            status.UpdateUser("UsersAccount", set, $"WHERE [AccountID] = '{userID}'");
        }

    }
}
