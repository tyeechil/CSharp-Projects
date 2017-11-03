using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOSChildress
{
    class Software:Disk
    {
        public string TypeSoft { get; set; }

        public Software() { }

        public Software(string type, string id, string desc, double price, int qty, string releaseDate, int numDisks, int size, string typeDisk,string typeSoft) : base(type, id, desc, price, qty, releaseDate, numDisks, size, typeDisk)
        {
            this.TypeSoft = typeSoft; 
        }


        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + TypeSoft;
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
        public string selectSoftware(string id)
        {
            return this.selectDisk() + "Software.TypeSoft FROM (((Product INNER JOIN Media ON Product.ID = Media.ID)INNER JOIN Disk ON Media.ID = Disk.ID)INNER JOIN Software ON Disk.ID = Software.ID)WHERE Product.ID = " + id + ";";
        }
    }
}
