using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Object_Problem
{
    class Book : Media
    {
        public int NumPages { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public Book()
        {
        }

        public Book(string type, string id, string desc, double price, int qty, string rDate, int numPages, string author, string publisher)
          : base(type, id, desc, price, qty, rDate)
        {
            this.NumPages = numPages;
            this.Author = author;
            this.Publisher = publisher;
        }

        public override string getDisplayText(string sep)
        {
            return base.getDisplayText(sep) + sep + (object)this.NumPages + sep + this.Author + sep + this.Publisher;
        }

        public override string ToString()
        {
            return this.getDisplayText("\r\n");
        }

        public override string ToCSV()
        {
            return this.getDisplayText(",");
        }
    }
}
