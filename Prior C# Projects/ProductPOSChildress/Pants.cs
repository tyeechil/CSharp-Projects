using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOSChildress
{
    class Pants:Apparel
    {
        public int Waist { get; set; }
        public int Inseam { get; set; }

        public Pants() { }

        public Pants(string type, string id, string desc, double price, int qty, string color, string manufacturer, string material, int waist, int inseam) : base(type, id, desc, price, qty, color, manufacturer, material)
        {
            this.Inseam = inseam;
            this.Waist = waist;
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Waist + sep + Inseam;
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
        public string selectPants(string id)
        {
            return this.selectApparel() + "Pants.Waist, Pants.Inseam FROM (Product INNER JOIN Apparel ON Product.ID = Apparel.ID) INNER JOIN Pants ON Apparel.ID = Pants.ID WHERE Product.ID = " + id + ";";
        }
    }
}
