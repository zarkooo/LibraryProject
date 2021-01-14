using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
namespace Common.Interfaces.Repository
{
    public interface ILogInRepository
    {
        Role LogIn(User user);
        string GetNameUser(string jmbg);

    }
}
