using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareMatrixLibrary
{
    public class UserService
    {
        private readonly Repository repo;

        public string UserInformation { get; set; }
        public string UserAccount { get; set; }

        public UserService()
        {
            repo = new Repository();
        }

        public void AddUser()
        {
            string UserInformationAttribute = "[UserID], [FirstName], [MiddleName], [LastName], [UsersRole]";
            string UserAccountAttribute = "AccountID, UsersID, Username, Email, _Password, DateCreated";

            repo.Add("Users", UserInformationAttribute, UserInformation);
            repo.Add("UsersAccount", UserAccountAttribute, UserAccount);
        }

        public bool GetUserByAccount(string email, string password)
        {
            bool IsValidAccount = false;
            string query = $@"SELECT Users.*, UsersAccount.*, UsersRole.* 
                            FROM UsersRole INNER JOIN 
                            (UsersAccount INNER JOIN Users ON UsersAccount.UsersID = Users.UserID) 
                            ON UsersRole.RoleID = Users.UsersRole 
                            WHERE UsersAccount.Email = '{email}' AND Usersaccount._Password = '{password}'";
            var hasGet = repo.Get(query);

            if (hasGet == true)
            {
                IsValidAccount = true;
            }

            return IsValidAccount;
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
