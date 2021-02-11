using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareMatrixLibrary
{
    public class UserService : UserModel
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
            string query = "SELECT Users.*, UsersAccount.*, UsersRole.* " + 
                            "FROM UsersRole INNER JOIN " + 
                            "(UsersAccount INNER JOIN Users ON UsersAccount.UsersID = Users.UserID) "+ 
                            "ON UsersRole.RoleID = Users.UsersRole " + 
                            $"WHERE UsersAccount.Email = '{email}' AND Usersaccount._Password = '{password}'";
            var hasGet = repo.Get(query);            

            if (hasGet == true)
            {
                IsValidAccount = true;

                UserID = repo.data[0].ToString();
                FirstName = repo.data[1].ToString();
                MiddleName = repo.data[2].ToString();
                Lastname = repo.data[3].ToString();
            }            

            return IsValidAccount;
        }

        public void RemoveUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(string tableName, string attributes, string values, string condition)
        {
            repo.Update(tableName, attributes, values, condition);
        }

    }
}
