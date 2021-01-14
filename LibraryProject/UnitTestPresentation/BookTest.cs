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
    public class BookTest
    {
        private readonly IBookBusiness bookBusiness = new BookBusiness();
        [TestMethod]
        public void TestDataGridView()
        {
            Books books = new Books();

            books.RefreshTable();

            

            Book book = new Book();
            book.Title = Guid.NewGuid().ToString();
            book.NameAuthor = Guid.NewGuid().ToString();
            book.ISBN = Guid.NewGuid().ToString();
            book.Quantity = 14;
            book.YearOfIssue = 2019;
            this.bookBusiness.AddBook(book);
            int countlista = bookBusiness.GetAllBooks().Count;

            books.RefreshTable();
            int count = books.TestRowCount;
            Assert.AreEqual(count,countlista);
          
        }
    }
}
