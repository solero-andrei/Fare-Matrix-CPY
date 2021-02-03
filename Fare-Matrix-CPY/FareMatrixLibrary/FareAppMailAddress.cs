using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareMatrixLibrary
{
    public class FareAppMailAddress
    {
        #region
        private string _Email = "";
        private string _Password = "";
        #endregion
        
        public string Password { get { return _Password; } }
        public string Email { get { return _Email; } }

    }
}
