using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces.Repository;
using Common.Models;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserRepository : IUserRepository
    {
        public bool AddUser(User user)
        {
            string query = string.Format("INSERT INTO Users values('{0}','{1}','{2}','{3}','{4}','{5}')",
                user.JmbgUser, user.Name, user.Surname, user.Email, user.Password, user.Role);
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool DeleteUser(string jmbg)
        {
            string query = "DELETE FROM Users WHERE JMBGUser='" + jmbg + "'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
        public bool UpdataUser(User user)
        {
            string query = string.Format("UPDATA Users SET  Name='{0}', Surname='{1}', Email='{2}', Password='{3}', Role='{4}' WHERE JMBGUser='{5}'",
                user.Name, user.Surname, user.Email, user.Password, user.Role, user.JmbgUser);
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
        public List<User> GetAllUsers()
        {
            return GetAllUsersInternal("SELECT * FROM Users");
        }
        private List<User>GetAllUsersInternal(string query)
        {
            List<User> list = new List<User>();
            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand(query))
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        User user = new User();
                        user.JmbgUser = sqlDataReader.GetString(0);
                        user.Name = sqlDataReader.GetString(1);
                        user.Surname = sqlDataReader.GetString(2);
                        user.Email = sqlDataReader.GetString(3);
                        user.Password = sqlDataReader.GetString(4);
                        user.Role = (Role)Enum.Parse(typeof(Role), sqlDataReader.GetString(5));
                        list.Add(user);

                    }
                }
            }
            return list;
        }
        public List<User> SearchUser(string search_by, User user)
        {
            string query = "";
            switch (search_by)
            {
                case "NAME":
                    query = string.Format("SELECT * FROM Users WHERE Name LIKE '%{0}%'",
                     user.Name);
                    return GetAllUsersInternal(query);
                   
                case "SURNAME":
                    query = string.Format("SELECT * FROM Users WHERE Surname LIKE '%{0}%'",
                    user.Surname);
                    return GetAllUsersInternal(query);
                default:
                    return new List<User>();
            }


        }
    }
}
