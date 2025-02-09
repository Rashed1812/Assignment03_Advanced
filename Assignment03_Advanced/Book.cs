using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_Advanced
{
    public class Book
    {

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _iSBN, string _title, string[] _authors, DateTime _publicationDate, decimal _price)
        {
            ISBN = _iSBN;
            Title = _title;
            Authors = _authors;
            PublicationDate = _publicationDate;
            Price = _price;
        }


        public override string ToString()
        {
            string authors = string.Join(",", Authors);
            return $"The ISBN Of Book Is {ISBN}\n" +
                   $"The Title Of Book Is {Title}\n" +
                   $"The Authors Of Book {authors}\n" +
                   $"Publication Date Of Book Is {PublicationDate}\n" +
                   $"The Price Of Book Is {Price}";
        }
    }
}
