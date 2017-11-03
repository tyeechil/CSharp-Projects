using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOSChildress
{
    class Book : Media
    {
        public string Author { get; set; }
        public int NumPages { get; set; }
        public string Publisher { get; set; }

        public Book() { }

        public Book(string type, string id, string desc, double price, int qty, string releaseDate, string author, int numPages  , string publisher) : base (type, id, desc, price, qty, releaseDate)
        {
            this.Publisher = publisher;
            this.Author = author;
            this.NumPages = numPages; 
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Author + sep + NumPages + sep + Publisher;
            return text;
        }

        public override string ToCSV()
        {
            string CSVString = getDisplayText(",");

            return CSVString;
        }

        public override string ToString()
        {
            string compstr = getDisplayText(" ");

            return compstr;
        }
        public string selectBook(string id)
        {
            return this.selectMedia() + "Book.NumPages, Book.Author, Book.Publisher FROM (((Product INNER JOIN Media ON Product.ID = Media.ID)INNER JOIN Book ON Media.ID = Book.ID)WHERE Product.ID = " + id + ";";
        }

    }
}
