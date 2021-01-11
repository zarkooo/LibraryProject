using System;
using System.Collections.Generic;

using BusinessLayer;
using Common.Interfaces.Business;
using Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using PresentationLayer.UserControls;

namespace UnitTestPresentation
{
    [TestClass]
    public class UserTest
    {
        private readonly IUserBusiness userBusiness = new UserBusiness();
        [TestMethod]
        public void TestDataGridView()
        {
            AddUser addUser = new AddUser();
            addUser.ReffresTable();

            User user = new User();
            user.JmbgUser = "7856785678561";
            user.Name = Guid.NewGuid().ToString();
            user.Surname = Guid.NewGuid().ToString();
            user.Password = "12345";
            user.Email = "janko.jankovic2@gmail.com";
            user.Role = Role.USER;

            this.userBusiness.AddUser(user);

            int countUser = this.userBusiness.GetAllUsers().Count;

            addUser.ReffresTable();

            int count = addUser.TestRowCount;

            Assert.IsTrue(countUser > 0);
            Assert.IsTrue(count > 0);

            Assert.AreEqual(count, countUser);
           

        }
    }
}
