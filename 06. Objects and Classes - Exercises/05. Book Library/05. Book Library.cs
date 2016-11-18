using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string releaseDate { get; set; }
        public string ISBNnumber { get; set; }
        public decimal price { get; set; }
    }

    class Library
    {
        public string name { get; set; }
        public List<Book> books { get; set; }
    }

    class BookLibrary
    {
        static void Main(string[] args)
        {
            
        }
    }
}
