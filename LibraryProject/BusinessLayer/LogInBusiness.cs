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
    public class LogInBusiness : ILogInBusiness
    {
        private readonly ILogInRepository iLR;
        public LogInBusiness(ILogInRepository iLR)
        {
            this.iLR = iLR;
        }
        public string GetNameUser(string jmbg)
        {
            return iLR.GetNameUser(jmbg);
        }

        public Role LogIn(User user)
        {
            return iLR.LogIn(user);
        }
    }
}
