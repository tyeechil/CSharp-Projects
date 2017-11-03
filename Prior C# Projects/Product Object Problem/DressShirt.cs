using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Object_Problem
{
    class DressShirt : Apparel
    {
        public double Neck { get; set; }

        public double Sleeve { get; set; }

        public DressShirt()
        {
        }

        public DressShirt(string type, string id, string desc, double price, int qty, string material, string color, string manufacturer, double neck, int sleeve)
          : base(type, id, desc, price, qty, material, color, manufacturer)
        {
            this.Neck = neck;
            this.Sleeve = (double)sleeve;
        }

        public override string getDisplayText(string sep)
        {
            return base.getDisplayText(sep) + sep + (object)this.Neck + sep + (object)this.Sleeve;
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
