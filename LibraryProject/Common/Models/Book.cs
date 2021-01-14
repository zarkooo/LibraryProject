using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
   public class Book
    {
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string NameAuthor { get; set; }
        public int YearOfIssue { get; set; }
        public int Quantity { get; set; }
    }
}
