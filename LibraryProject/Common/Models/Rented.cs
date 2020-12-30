using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
   public  class Rented
    {
        public int IdRented { get; set; }

        public DateTime DateOfIssue { get; set; }
        
        public DateTime ReturnDate { get; set; }
    }
}
