using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class Validator
    {
        string LastName, FirstName, MiddleName, Username, Email, Password, ConfirmPassword;
        System.Windows.Forms.PictureBox image;
        const int PasswordLength = 8;

        public Validator(string _lastName, string _firstName, string _middleName, 
            string _username, string _email, string _password, string _confirmPassword, System.Windows.Forms.PictureBox _image)
        {
            this.LastName = _lastName;
            this.FirstName = _firstName;
            this.MiddleName = _middleName;
            this.Username = _username;
            this.Email = _email;
            this.Password = _password;
            this.ConfirmPassword = _confirmPassword;
            this.image = _image;
        }

        private bool RequiredFields()
        {
            bool IsValid;
            if (LastName.Equals(string.Empty) && FirstName.Equals(string.Empty) && MiddleName.Equals(string.Empty)
                && Username.Equals(string.Empty) && Email.Equals(string.Empty) && Password.Equals(string.Empty)
                && ConfirmPassword.Equals(string.Empty))
                IsValid = false;
            else
                IsValid = true;
            return IsValid;
        }

        private bool PasswordConfirmation()
        {
            bool IsValid;
            if (Password == ConfirmPassword)
                IsValid = true;
            else
                IsValid = false;

            return IsValid;
        }

        private bool EmailValidation()
        {
            bool IsValid;
            try
            {
                var validEmail = new System.Net.Mail.MailAddress(Email).ToString();
                IsValid = true;
            }
            catch
            {
                IsValid = false;
            }
            return IsValid;
        }

        private bool PasswordValidation()
        {
            bool IsValid;

            if (Password.Length >= PasswordLength && Password.Any(char.IsUpper) && Password.Any(char.IsLower) && Password.Any(char.IsLetterOrDigit))
                IsValid = true;
            else
                IsValid = false;

            return IsValid;
        }

        public bool ValidateAccount()
        {
            bool IsValid = true;
            AdminAccount admin = new AdminAccount();

            if (RequiredFields() == true && PasswordConfirmation() == true
                && EmailValidation() == true && PasswordValidation() == true)
            {
                admin.SaveImage(image);
                admin.SaveInformation(LastName, FirstName, MiddleName);
                admin.SaveAccount(Email, Password, Username);

                IsValid = true;
            }
            else
                IsValid = false;

            return IsValid;
        }

    }
}
