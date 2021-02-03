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
        public void SendWelcomeMessage()
        {
            FareAppMailAddress fareappmail = new FareAppMailAddress();

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("soleroandrei0829@gmail.com", "Hindikoalam"),
                EnableSsl = true
            };
            client.Send("soleroandrei0829@gmail.com", Email, "Hello welcome sa amin fare matrix", "Basta naglogin ka sa fare matrix, gawa naming jpg, ay basta, ay ewan.");
        }
    }
}
