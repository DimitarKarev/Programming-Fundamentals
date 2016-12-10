using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    

    class BookLibrary
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();
            myLibrary.books = new List<Book>();
            var numberOfBooks = int.Parse(Console.ReadLine());

            GetAllBooks(myLibrary, numberOfBooks);

            FilterbyAuthorAndPrint(myLibrary);
        }

        private static void GetAllBooks(Library myLibrary, int numberOfBooks)
        {
            for (int books = 0; books < numberOfBooks; books++)
            {
                Book currentBook = new Book();
                string[] currentBookParams = Console.ReadLine().Split().ToArray();

                GetBookInfo(currentBook, currentBookParams);

                myLibrary.books.Add(currentBook);
            }
        }

        private static void GetBookInfo(Book currentBook, string[] currentBookParams)
        {
            currentBook.title = currentBookParams[0];
            currentBook.author = currentBookParams[1];
            currentBook.publisher = currentBookParams[2];
            currentBook.releaseDate = currentBookParams[3];
            currentBook.ISBNnumber = currentBookParams[4];
            currentBook.price = decimal.Parse(currentBookParams[5]);
        }

        private static void FilterbyAuthorAndPrint(Library myLibrary)
        {
            var filteredBooks = myLibrary.books.Select(b => new
            {
                Author = b.author,
                EarningsTotal = myLibrary.books
                .Where(b1 => b1.author.Equals(b.author))
                .Sum(b1 => b1.price)
            })
                .Distinct().OrderByDescending(b => b.EarningsTotal).ThenBy(b => b.Author).ToList();

            foreach (var book in filteredBooks)
            {
                Console.WriteLine("{0} -> {1:f2}", book.Author, book.EarningsTotal);
            }
        }
    }

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
}
