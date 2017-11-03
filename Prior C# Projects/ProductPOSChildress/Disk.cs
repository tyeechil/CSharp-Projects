using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOSChildress
{
    class Disk:Media
    {

        public int NumDisks { get; set; }
        public int Size { get; set; }
        public string TypeDisk { get; set; }


        public Disk() { }

        public Disk(string type, string id, string desc, double price, int qty, string releaseDate,int numDisks, int size, string typeDisk) : base(type, id, desc, price, qty, releaseDate)
        {
            this.TypeDisk = typeDisk;
            this.NumDisks = numDisks;
            this.Size = size;
        }


        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Size + sep + NumDisks + sep + TypeDisk;
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
        public string selectDisk()
        {
            return this.selectMedia() + "Disk.Size, Disk.NumDisks, Disk.TypeDisk, ";
        }
    }
}
