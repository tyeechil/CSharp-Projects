using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOSChildress
{
    class TShirt : Apparel
    {
        public string Size { get; set; }

        public TShirt() { }

        public TShirt(string type, string id, string desc, double price, int qty, string color, string manufacturer, string material,string size) : base(type, id, desc, price, qty, color, manufacturer, material)
        {
            this.Size = size;
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Size;
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
        public string selectTShirt(string id)
        {
            return this.selectApparel() + "TShirt.Size FROM (Product INNER JOIN Apparel ON Product.ID = Apparel.ID) INNER JOIN TShirt ON Apparel.ID = TShirt.ID WHERE Product.ID = " + id + ";";
        }
    }
}

