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
    public class BookTest
    {
        private Mock<IBookRepository> mockBookRepository = new Mock<IBookRepository>();
        private IBookBusiness bookBusiness = new BookBusiness();
        [TestMethod]
        public void IsBookInserted()
        {
            Book book = new Book();
            book.ISBN = "1213";
            book.NameAuthor = "Njegos";
            book.Quantity = 6;
            book.Title = "Lampa";
            book.YearOfIssue = 1234;

                // Arrange
            mockBookRepository.Setup(x => x.AddBook(book)).Returns(true);
            this.bookBusiness = new BookBusiness();
            // Act
            var result = bookBusiness.AddBook(book);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsBookRemoved()
        {
            Book book = new Book();
            List<int> litId = (from iter in bookBusiness.GetAllBooks()
                               select iter.IdBook).ToList();
            mockBookRepository.Setup(x => x.DeleteBook(litId[0])).Returns(true);
            var result = bookBusiness.DeleteBook(litId[0]);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsBookUpdated()
        {
            Book book = new Book();
            List<int> litId = (from iter in bookBusiness.GetAllBooks()
                               select iter.IdBook).ToList();


            book.Title = Guid.NewGuid().ToString();
            book.NameAuthor = Guid.NewGuid().ToString();
            book.ISBN = Guid.NewGuid().ToString();
            book.Quantity = Guid.NewGuid().GetHashCode();
            book.YearOfIssue = Guid.NewGuid().GetHashCode();
            book.IdBook = litId[0];

            mockBookRepository.Setup(x => x.UpdataBook(book)).Returns(true);
            var result = bookBusiness.UpdataBook(book);

            Assert.IsTrue(result);
        }
    }
}
