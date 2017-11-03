using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOSChildress
{
    class Movie:Entertainment
    {
        public string Director { get; set; }
        public string Producer { get; set; }

        public Movie() { }

        public Movie(string type, string id, string desc, double price, int qty, string releaseDate, int numDisks, int size, string typeDisk, TimeSpan runTime,string director, string producer) : base(type, id, desc, price, qty, releaseDate, numDisks, size, typeDisk, runTime)
        {
            this.Director = director;
            this.Producer = producer;
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Director + sep + Producer;
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
        public string selectMovie(string id)
        {
            return this.selectEntertainment() + "Movie.Director, Movie.Producer FROM (((Product INNER JOIN Media ON Product.ID = Media.ID)INNER JOIN Disk ON Media.ID = Disk.ID)INNER JOIN Entertainment ON Disk.ID = Entertainment.ID)INNER JOIN Movie ON Entertainment.ID = Movie.ID WHERE Product.ID = " + id + ";";
        }
    }
}
