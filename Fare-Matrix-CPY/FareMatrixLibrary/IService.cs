using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareMatrixLibrary
{
    public interface IService
    {
        void AddUser(string role, string[] attributes, string[] values);
        void RemoveUser();
        void UpdateUser();
        void GetUserByID();

    }
}
