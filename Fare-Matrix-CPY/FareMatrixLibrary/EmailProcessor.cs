using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace FareMatrixLibrary
{
    public class EmailProcessor : UserModel
    {
        public void Send(string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(FareAppMailAddress.Email, FareAppMailAddress.Password),
                EnableSsl = true
            };
            client.Send(FareAppMailAddress.Email, Email, subject, message);
        }
    }
}
