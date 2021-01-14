using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
namespace Common.Interfaces.Repository
{
    public interface IBookRepository
    {
       
        bool AddBook(Book book);
        bool UpdataBook(Book book);
        bool DeleteBook(int IdBook);
        List<Book> GetAllBooks();
        bool ReturnBook(string JmbgUser, Book book);
        bool RentedBook(string JmbgUser, Rented rented);
        List<Book> SearchBook(string search_by, Book book);
        bool SetQuantity(Book book);
        bool IncrementQuantity(Book book);
        bool DecrementQuantity(Book book);
        List<Tuple<List<Rented>, List<User>>> GetAllBookRentedUsers();
    }
}
