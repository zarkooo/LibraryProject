using Common.Interfaces.Business;
using Common.Interfaces.Repository;
using Common.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository iUR;

        public UserBusiness(IUserRepository iUR)
        {
            this.iUR = iUR;
        }
        public bool AddUser(User user)
        {
            return iUR.AddUser(user);
        }

        public bool DeleteUser(string jmbg)
        {
            return iUR.DeleteUser(jmbg);
        }

        public List<User> GetAllUsers()
        {
            return iUR.GetAllUsers();
        }

        public List<User> SearchUser(string search_by, User user)
        {
            return iUR.SearchUser(search_by,user);
        }

        public List<User> SortUser()
        {
            List<User> userList = GetAllUsers();
            var usersAscending = userList.OrderBy(s => s.Name);
            return userList;
        }

        public bool UpdataUser(User user)
        {
            return iUR.UpdataUser(user);
        }
    }
}
