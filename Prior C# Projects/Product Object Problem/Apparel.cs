using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Object_Problem
{
    class Apparel : Product
    {
        public string Material { get; set; }

        public string Color { get; set; }

        public string Manufacturer { get; set; }

        public Apparel()
        {
        }

        public Apparel(string type, string id, string desc, double price, int qty, string material, string color, string manufacturer)
          : base(type, id, desc, price, qty)
        {
            this.Material = material;
            this.Color = color;
            this.Manufacturer = manufacturer;
        }

        public override string getDisplayText(string sep)
        {
            return base.getDisplayText(sep) + sep + this.Material + sep + this.Color + sep + this.Manufacturer;
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
