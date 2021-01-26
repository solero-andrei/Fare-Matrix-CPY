using FareMatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare_Matrix_CPY.AdminPortal
{
    public class AdminAccount : UserModel, IProcessor
    {
        public void Add()
        {
            DataAccess data = new DataAccess
            {
                
            };

            data.DataExecution();

        }
    }
}
