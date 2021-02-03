using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareMatrixLibrary
{
    public interface IService
    {
        void AddUser();
        void RemoveUser();
        void UpdateUser();
        void GetUserByAccount(string email, string password);
    }
}
