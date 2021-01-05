using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public abstract class SortStrategy
    {
        public abstract List<Book> Sort(List<Book> list);
    }

    class ByName : SortStrategy
    {
        public override List<Book> Sort(List<Book> list)
        {
            return list.OrderBy(s => s.Title).ToList();
        }
    }

    class ByISBN : SortStrategy
    {
        public override List<Book> Sort(List<Book> list)
        {
            return list.OrderBy(s => s.ISBN).ToList();
        }
    }

    public class BookSortedList
    {
        private List<Book> list;
        private SortStrategy sortStrategy;

        public List<Book> List { get { return list; } set { list = value; } }

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public List<Book> Sort()
        {
            return this.sortStrategy.Sort(list);
        }
    }
}
