using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareMatrixLibrary
{
    public class UserService : IService
    {
        private readonly Repository repo;

        public UserService()
        {
            repo = new Repository();
        }

        public void AddUser(string role, string[] attributes, string[] values)
        {
            string attribute = string.Join(",", attributes);
            string value = string.Join(",", values);

            repo.Add(role, attribute, value);
        }

        public void GetUserByID()
        {
            throw new NotImplementedException();
        }
        
        public void RemoveUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }

    }
}
