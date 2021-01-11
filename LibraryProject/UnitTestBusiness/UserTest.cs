using BusinessLayer;
using Common.Interfaces.Business;
using Common.Interfaces.Repository;
using Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestBusiness
{
    [TestClass]
    public class UserTest
    {
        private Mock<IUserRepository> mockUserRepository = new Mock<IUserRepository>();
        private IUserBusiness userBusiness = new UserBusiness();
        [TestMethod]
        public void IsUserInserted()
        {
            User user = new User();
            user.JmbgUser = "1234123412346";
            user.Name = "Njegos";
            user.Surname = "Njegosevic";
            user.Password = "njegos";
            user.Email = "bubu1234@gugu.com";
            user.Role = Role.LIBRARIAN;

            // Arrange
            mockUserRepository.Setup(x => x.AddUser(user)).Returns(true);
            this.userBusiness = new UserBusiness();
            // Act
            var result = userBusiness.AddUser(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUserRemoved()
        {
            User user = new User();
            List<String> JmbgUser = (from iter in userBusiness.GetAllUsers()
                               select iter.JmbgUser).ToList();
            mockUserRepository.Setup(x => x.DeleteUser(JmbgUser[1])).Returns(true);
            var result = userBusiness.DeleteUser(JmbgUser[1]);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUserUpdated()
        {
            User user = new User();
            List<String> JmbgUser = (from iter in userBusiness.GetAllUsers()
                               select iter.JmbgUser).ToList();

            user.JmbgUser = JmbgUser[0];
            user.Name = Guid.NewGuid().ToString();
            user.Surname = Guid.NewGuid().ToString();
            user.Password = Guid.NewGuid().ToString();
            user.Email = Guid.NewGuid().ToString();
            user.Role = Role.LIBRARIAN;

            mockUserRepository.Setup(x => x.UpdataUser(user)).Returns(true);
            var result = userBusiness.UpdataUser(user);

            Assert.IsTrue(result);
        }
    }
}
