﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Object_Problem
{
    class TShirt : Apparel
    {
        public string Size { get; set; }

        public TShirt()
        {
        }

        public TShirt(string type, string id, string desc, double price, int qty, string material, string color, string manufacturer, string size)
          : base(type, id, desc, price, qty, material, color, manufacturer)
        {
            this.Size = size;
        }

        public override string getDisplayText(string sep)
        {
            return base.getDisplayText(sep) + sep + this.Size;
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
