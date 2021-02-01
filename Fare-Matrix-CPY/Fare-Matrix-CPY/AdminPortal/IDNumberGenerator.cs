using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class IDNumberGenerator
    {
        public static string IDInformation()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }

        public static int Account()
        {
            Random ran = new Random();
            int ranID = ran.Next(10000);

            return ranID;
        }
    }
}
