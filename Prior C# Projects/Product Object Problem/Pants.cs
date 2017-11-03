using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Object_Problem
{
    class Pants : Apparel
    {
        public int Waist { get; set; }

        public int Inseam { get; set; }

        public Pants()
        {
        }

        public Pants(string type, string id, string desc, double price, int qty, string material, string color, string manufacturer, int waist, int inseam)
          : base(type, id, desc, price, qty, material, color, manufacturer)
        {
            this.Waist = waist;
            this.Inseam = inseam;
        }

        public override string getDisplayText(string sep)
        {
            return base.getDisplayText(sep) + sep + (object)this.Waist + sep + (object)this.Inseam;
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
