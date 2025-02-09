using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_Advanced
{
    internal class BookFunction
    {
        public static string GetTitle (Book book)
        {
            if (book == null && book?.Title is null)
               return "Book Doesn't Founded";
            return $"Tittle: {book.Title}";
        }
        public static string GetAuthors(Book book)
        {
            if (book == null)
                return "Book Doesn't Founded";
            return $"Authors: {book.Authors}";
        }
        public static string GetPrice(Book book)
        {
            if (book == null)
                return "Book Doesn't Founded";
            return $"Price: {book.Price}";
        }
    }
}
