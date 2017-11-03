using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOSChildress
{
    class Entertainment:Disk
    {
        private TimeSpan runTime;

        public Entertainment() { }

        public Entertainment(string type, string id, string desc, double price, int qty, string releaseDate, int numDisks, int size, string typeDisk, TimeSpan runTime) :base(type, id, desc, price, qty, releaseDate,numDisks,size,typeDisk)
        {
            this.runTime = runTime;
        }

        public string RunTime
        {
            get
            {
                return this.runTime.Hours.ToString() + ":" + this.runTime.Minutes.ToString() + ":" + this.runTime.Seconds.ToString();
            }
            set
            {
                string[] strArray = value.Split(':');
                this.runTime = new TimeSpan(int.Parse(strArray[0]), int.Parse(strArray[1]), int.Parse(strArray[2]));
            }
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + RunTime;
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
        public string selectEntertainment()
        {
            return this.selectDisk() + "Entertainment.Hours, Entertainment.Minutes, Entertainment.Seconds, ";
        }
    }
}
