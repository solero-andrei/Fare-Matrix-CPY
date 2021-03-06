﻿using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class ValidateSave : UserModel
    {
        public string ConfirmPassword { get; set; }
        public System.Windows.Forms.PictureBox image { get; set; }
        const int PasswordLength = 8;

        private bool RequiredFields()
        {
            bool IsValid;
            if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(MiddleName) && string.IsNullOrWhiteSpace(Lastname)
                && string.IsNullOrWhiteSpace(Username) && string.IsNullOrWhiteSpace(Email) && string.IsNullOrWhiteSpace(Password)
                && string.IsNullOrWhiteSpace(ConfirmPassword))
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
            bool IsValid = false;
            AdminAccount admin = new AdminAccount();
            EmailProcessor adminEmail = new EmailProcessor { Email = Email};

            if (RequiredFields() == true && PasswordConfirmation() == true && EmailValidation() == true
                && PasswordValidation() == true)
            {
                string information = $"'{FirstName}', '{MiddleName}', '{Lastname}'";
                string account = $"'{Username}', '{Email}', '{Password}'";

                admin.Save(information, account);
                admin.SaveImage(image);
                adminEmail.Send("Fare Matrix Registration",
                    "Your account is now verified. You can now safely use the Application.\nYou can use this email to recover your account on our application.\n\n-Fare Matrix Developer");

                IsValid = true;
            }

            return IsValid;
        }

    }
}
