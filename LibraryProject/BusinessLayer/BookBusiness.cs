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
    public class BookBusiness : IBookBusiness
    {
        private readonly IBookRepository iBR;
        public BookBusiness(IBookRepository iBR)
        {
            this.iBR = iBR;
        }
        public bool AddBook(Book book)
        {
            foreach(var item in GetAllBooks())
            {
                if(item.Title.Equals(book.Title) && item.NameAuthor.Equals(book.NameAuthor) && item.ISBN.Equals(book.ISBN) && item.YearOfIssue.Equals(book.YearOfIssue))
                {
                    return iBR.SetQuantity(book);
                }
            }
            return iBR.AddBook(book);
        }

        public bool DeleteBook(int IdBook) => iBR.DeleteBook(IdBook);

        public List<Tuple<List<Rented>, List<User>>> GetAllBookRentedUsers() => iBR.GetAllBookRentedUsers();

        public List<Book> GetAllBooks() => iBR.GetAllBooks();

        public bool RentedBook(string JmbgUser, Rented rented)
        {
            List<User> usersRenting = null;
            int br = 0;

            foreach(var renter in GetAllBookRentedUsers())
            {
                usersRenting = renter.Item2.ToList();
            }

            bool tempino = false;

            foreach(var temp in usersRenting)
            {
                if (temp.JmbgUser.Equals(JmbgUser))
                    br++;
                if (br == 2)
                {
                    tempino = false;
                    break;
                }
            }

            if (tempino == true)
            {
                if (iBR.RentedBook(JmbgUser, rented))
                {
                    return iBR.DecrementQuantity(rented);
                }
                return iBR.RentedBook(JmbgUser, rented);
            }

            return false;
        }

        public bool ReturnBook(string JmbgUser, Book book)
        {
            if (iBR.ReturnBook(JmbgUser, book))
            {
                return iBR.IncrementQuantity(book);
            }
            return iBR.ReturnBook(JmbgUser, book);
        }

        public List<Book> SearchBook(string search_by, Book book) => iBR.SearchBook(search_by,book);

        public List<Book> SortBook(List<Book> list, string sortType)
        {
            BookSortedList bookList = new BookSortedList();
            bookList.List = list;

            switch (sortType)
            {
                case "Title":
                    bookList.SetSortStrategy(new ByName());
                    break;
                case "ISBN":
                    bookList.SetSortStrategy(new ByISBN());
                    break;
                default:
                    break;
            }

            bookList.Sort();
            return bookList.List;
        }

        public bool UpdataBook(Book book) => iBR.UpdataBook(book);
    }
}
