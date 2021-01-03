using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
namespace Common.Interfaces.Repository
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        bool DeleteUser(string jmbg);
        List<User> GetAllUsers();
        List<User> SearchUser(string search_by, User user);
    }
}
