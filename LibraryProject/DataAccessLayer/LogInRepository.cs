using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common.Interfaces.Repository;
using Common.Models;

namespace DataAccessLayer
{
    public class LogInRepository : ILogInRepository
    {
        public string GetNameUser(string jmbg)
        {
            string query = "SELECT Name FROM Users WHERE JMBGUser='" + jmbg + "'";
            return (string)BaseConnection.ExecuteScalarSqlCommand(query);
        }

        public Role LogIn(User user)
        {
            string query = string.Format("SELECT Role FROM Users WHERE JMBGUser='{0}' AND Password='{1}'",
                user.JmbgUser, user.Password);

            string role = (string)BaseConnection.ExecuteScalarSqlCommand(query);

            return role == null ? Role.NONE : (Role)Enum.Parse(typeof(Role), role);

        }
    }
}
