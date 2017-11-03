using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOSChildress
{
    class Music:Entertainment

    {
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Label { get; set; }


        public Music() { }

        public Music(string type, string id, string desc, double price, int qty, string releaseDate, int numDisks, int size, string typeDisk, TimeSpan runTime, string artist, string label, string genre ):base(type, id, desc, price, qty, releaseDate, numDisks,size,typeDisk,runTime)
        {
            this.Artist = artist;
            this.Genre = genre;
            this.Label = label ;

        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Artist + sep + Label + sep + Genre;
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
        public string selectMusic(string id)
        {
            return this.selectEntertainment() + "Music.Genre, Music.Artist, Music.Artist FROM (((Product INNER JOIN Media ON Product.ID = Media.ID)INNER JOIN Disk ON Media.ID = Disk.ID)INNER JOIN Entertainment ON Disk.ID = Entertainment.ID)INNER JOIN Music ON Entertainment.ID = Music.ID WHERE Product.ID = " + id + ";";
        }
    }
}
