﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Object_Problem
{
    class Music : Entertainment
    {
        public string Genre { get; set; }

        public string Artist { get; set; }

        public string Label { get; set; }

        public Music()
        {
        }

        public Music(string type, string id, string desc, double price, int qty, string rDate, int size, int numDisks, string typeDisk, string rTime, string genre, string artist, string label)
          : base(type, id, desc, price, qty, rDate, size, numDisks, typeDisk, rTime)
        {
            this.Genre = genre;
            this.Artist = artist;
            this.Label = label;
        }

        public override string getDisplayText(string sep)
        {
            return base.getDisplayText(sep) + sep + this.Genre + sep + this.Artist + sep + this.Label;
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
