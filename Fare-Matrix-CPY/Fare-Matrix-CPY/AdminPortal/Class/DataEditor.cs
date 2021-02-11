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
        UserService service;

        public void Information()
        {
            service = new UserService();

        }

    }
}
