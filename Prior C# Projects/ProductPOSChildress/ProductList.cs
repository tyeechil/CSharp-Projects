using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPOSChildress
{
    class ProductList:List<Product>
    {

        public void readFromFile()
        {
            string dir = @"Outputs";
            string path = dir + "/Products.csv";
            StreamReader reader;
            string[] splitstr;
            string curLine;
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Directory not found '" + dir + "'");
            }
            else if (!File.Exists(path))
            {
                MessageBox.Show("File not found '" + path + "'");
                return;
            }
            else
            {
                reader = new StreamReader(path);
                while ((curLine = reader.ReadLine()) != null)
                {
                    splitstr = curLine.Split(',');
                    this.Add(splitstr);
                }
                reader.Close();
            }
        }

        public void readFromBinary()
        {
            string dir = @"Outputs";
            string path = dir + "/Output.bin";

            BinaryReader binaryIn = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            while(binaryIn.PeekChar() != -1)
            {
                this.Add(binaryIn.ReadString().Split(','));
            }
            binaryIn.Close();
        }

        public void writeToFile()
        {
            string dir = @"Outputs";
            string path = dir + "/Output.csv";

            StreamWriter textOut = new StreamWriter(new FileStream(path,
                FileMode.Create, FileAccess.Write));

            foreach (Product p in this)
            {
                textOut.WriteLine(p.ToCSV());
            }

            // Close StreamWriter
            textOut.Close();

        }

        public void writeToBinary()
        {
            string dir = @"Outputs";
            string path = dir + "/Output.bin";

            BinaryWriter binaryOut = new BinaryWriter(new FileStream(path,
                FileMode.Create, FileAccess.Write));

            foreach (Product p in this)
            {
                binaryOut.Write(p.ToCSV());
            }
            binaryOut.Close();
        }

        


        public void Add(string[] splitstr)
        {
            if(splitstr[0] == "DressShirt")
            {
                this.Add(new DressShirt(splitstr[0], splitstr[1], splitstr[2], double.Parse(splitstr[3]), int.Parse(splitstr[4]), splitstr[6], splitstr[7], splitstr[5], int.Parse(splitstr[8]), int.Parse(splitstr[9])));
            }
            else if(splitstr[0] == "Pants")
            {
                this.Add(new Pants(splitstr[0], splitstr[1], splitstr[2], double.Parse(splitstr[3]), int.Parse(splitstr[4]),splitstr[6], splitstr[7], splitstr[5], int.Parse(splitstr[8]), int.Parse(splitstr[9])));
            }
            else if (splitstr[0] == "TShirt")
            {
                this.Add(new TShirt(splitstr[0], splitstr[1], splitstr[2], double.Parse(splitstr[3]), int.Parse(splitstr[4]), splitstr[6], splitstr[7], splitstr[5], splitstr[8]));
            }
            else if (splitstr[0] == "Book")
            {
                this.Add(new Book(splitstr[0], splitstr[1], splitstr[2], double.Parse((splitstr[3])), int.Parse((splitstr[4])), splitstr[5], splitstr[6], int.Parse(splitstr[7]), splitstr[8]));
            }
            else if (splitstr[0] == "Software")
            {
                this.Add(new Software(splitstr[0], splitstr[1], splitstr[2], double.Parse((splitstr[3])), int.Parse((splitstr[4])), splitstr[5], int.Parse(splitstr[6]), int.Parse(splitstr[7]), splitstr[8], splitstr[9]));
            }
            else if (splitstr[0] == "Movie")
            {
                this.Add(new Movie(splitstr[0], splitstr[1], splitstr[2], double.Parse((splitstr[3])), int.Parse((splitstr[4])), splitstr[5], int.Parse(splitstr[6]), int.Parse(splitstr[7]), splitstr[8], TimeSpan.Parse(splitstr[9]), splitstr[10], splitstr[11]));

            }
            else if (splitstr[0] == "Music")
            {
                this.Add(new Music(splitstr[0], splitstr[1], splitstr[2], double.Parse((splitstr[3])), int.Parse((splitstr[4])), splitstr[5], int.Parse(splitstr[6]), int.Parse(splitstr[7]), splitstr[8], TimeSpan.Parse(splitstr[9]), splitstr[10], splitstr[12], splitstr[11]));
            }
        }

        public virtual string ToCSV()
        {
            string CSVString = "";
            foreach (Product product in (List<Product>) this)
                CSVString = CSVString + product.ToCSV() + "\r\n";
            return CSVString;
        }

        public override string ToString()
        {
           
            string compstr = "";
            foreach (Product product in (List<Product>)this)
                compstr = compstr + product.ToString() + "\r\n\r\n";
            return compstr;
        }



    }
}
