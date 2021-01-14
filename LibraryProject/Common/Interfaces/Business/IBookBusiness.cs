using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.Business
{
    public interface IBookBusiness
    {
        bool AddBook(Book book);
        bool UpdataBook(Book book);
        bool DeleteBook(int IdBook);
        List<Book> GetAllBooks();
        bool ReturnBook(string JmbgUser, Book book);
        bool RentedBook(string JmbgUser, Rented rented);
        List<Book> SearchBook(string search_by, Book book);
        List<Tuple<List<Rented>, List<User>>> GetAllBookRentedUsers();
        List<Book> SortBook(List<Book> list, string sortType);
    }
}
