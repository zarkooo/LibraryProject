using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.Business
{
    public interface IUserBusiness
    {
        bool AddUser(User user);
        bool DeleteUser(string jmbg);
        bool UpdataUser(User user);
        List<User> GetAllUsers();
        List<User> SearchUser(string search_by, User user);
        List<User> SortUser();
    }
}
