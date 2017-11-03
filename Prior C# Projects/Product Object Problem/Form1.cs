using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Object_Problem
{
    public partial class Form1 : Form
    {
        private ProductList pl = new ProductList();
        private int idx = -1;
        private Product p;
        private Button btnRead;
        private Button btnExit;
        private Button btnWrite;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblType;
        private TextBox txtType;
        private TextBox txtID;
        private Label lblID;
        private TextBox txtDesc;
        private Label lblDesc;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtVar1;
        private Label lblVar1;
        private TextBox txtVar2;
        private Label lblVar2;
        private TextBox txtVar3;
        private Label lblVar3;
        private TextBox txtVar4;
        private Label lblVar4;
        private TextBox txtVar5;
        private Label lblVar5;
        private TextBox txtVar6;
        private Label lblVar6;
        private TextBox txtVar7;
        private Label lblVar7;
        private TextBox txtVar8;
        private Label lblVar8;
        private Button btnWriteBin;
        private Button btnReadBin;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            this.pl.Clear();
            this.pl.readFromFile("Products.csv");
            this.idx = 0;
            this.drawProduct();
            this.btnPrevious.Enabled = false;
            this.btnNext.Enabled = true;
            this.btnWrite.Enabled = true;
            this.btnWriteBin.Enabled = true;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            this.pl.writeToFile("Output.csv");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.drawSet(false, false, false, false, false, false, false, false);
            this.btnPrevious.Enabled = false;
            this.btnNext.Enabled = false;
            this.btnWrite.Enabled = false;
            this.btnWriteBin.Enabled = false;
        }

        public void drawSet(bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7, bool b8)
        {
            this.lblVar1.Visible = b1;
            this.txtVar1.Visible = b1;
            this.lblVar2.Visible = b2;
            this.txtVar2.Visible = b2;
            this.lblVar3.Visible = b3;
            this.txtVar3.Visible = b3;
            this.lblVar4.Visible = b4;
            this.txtVar4.Visible = b4;
            this.lblVar5.Visible = b5;
            this.txtVar5.Visible = b5;
            this.lblVar6.Visible = b6;
            this.txtVar6.Visible = b6;
            this.lblVar7.Visible = b7;
            this.txtVar7.Visible = b7;
            this.lblVar8.Visible = b8;
            this.txtVar8.Visible = b8;
        }

        public void drawProduct()
        {
            if (this.idx < 0 || this.idx >= this.pl.Count)
                return;
            this.p = this.pl.ElementAt<Product>(this.idx);
            this.txtType.Text = this.p.Type;
            this.txtID.Text = this.p.ID;
            this.txtDesc.Text = this.p.Desc;
            this.txtPrice.Text = this.p.Price.ToString("C");
            this.txtQuantity.Text = this.p.Qty.ToString();
            if (this.p.Type == "Book")
                this.drawBook();
            else if (this.p.Type == "Software")
                this.drawSoftware();
            else if (this.p.Type == "Music")
                this.drawMusic();
            else if (this.p.Type == "Movie")
                this.drawMovie();
            else if (this.p.Type == "Pants")
                this.drawPants();
            else if (this.p.Type == "TShirt")
                this.drawTShirt();
            else if (this.p.Type == "DressShirt")
            {
                this.drawDressShirt();
            }
            else
            {
                int num = (int)MessageBox.Show("Not found.");
            }
        }

        public void drawMedia()
        {
            Media p = (Media)this.p;
            this.lblVar1.Text = "Release Date";
            this.txtVar1.Text = p.ReleaseDate;
        }

        public void drawApparel()
        {
            Apparel p = (Apparel)this.p;
            this.lblVar1.Text = "Color";
            this.txtVar1.Text = p.Color;
            this.lblVar2.Text = "Manufacturer";
            this.txtVar2.Text = p.Manufacturer;
            this.lblVar3.Text = "Material";
            this.txtVar3.Text = p.Material;
        }

        public void drawDisk()
        {
            Disk p = (Disk)this.p;
            this.drawMedia();
            this.lblVar2.Text = "Number of Disks";
            this.txtVar2.Text = p.NumDisks.ToString();
            this.lblVar3.Text = "Data Size";
            this.txtVar3.Text = p.Size.ToString();
            this.lblVar4.Text = "Type Disk";
            this.txtVar4.Text = p.TypeDisk;
        }

        public void drawEntertainment()
        {
            Entertainment p = (Entertainment)this.p;
            this.drawDisk();
            this.lblVar5.Text = "Runtime";
            this.txtVar5.Text = p.RunTime;
        }

        public void drawBook()
        {
            Book p = (Book)this.p;
            this.drawSet(true, true, true, true, false, false, false, false);
            this.drawMedia();
            this.lblVar2.Text = "Author";
            this.txtVar2.Text = p.Author;
            this.lblVar3.Text = "Pages";
            this.txtVar3.Text = p.NumPages.ToString();
            this.lblVar4.Text = "Publisher";
            this.txtVar4.Text = p.Publisher;
        }

        public void drawSoftware()
        {
            Software p = (Software)this.p;
            this.drawSet(true, true, true, true, true, false, false, false);
            this.drawDisk();
            this.lblVar5.Text = "Type Software";
            this.txtVar5.Text = p.TypeSoft;
        }

        public void drawMusic()
        {
            Music p = (Music)this.p;
            this.drawSet(true, true, true, true, true, true, true, true);
            this.drawEntertainment();
            this.lblVar6.Text = "Artist";
            this.txtVar6.Text = p.Artist;
            this.lblVar7.Text = "Label";
            this.txtVar7.Text = p.Label;
            this.lblVar8.Text = "Genre";
            this.txtVar8.Text = p.Genre;
        }

        public void drawMovie()
        {
            Movie p = (Movie)this.p;
            this.drawSet(true, true, true, true, true, true, true, false);
            this.drawEntertainment();
            this.lblVar6.Text = "Director";
            this.txtVar6.Text = p.Director;
            this.lblVar7.Text = "Producer";
            this.txtVar7.Text = p.Producer;
        }

        public void drawPants()
        {
            Pants p = (Pants)this.p;
            this.drawSet(true, true, true, true, true, false, false, false);
            this.drawApparel();
            this.lblVar4.Text = "Waist";
            this.txtVar4.Text = p.Waist.ToString();
            this.lblVar5.Text = "Inseam";
            this.txtVar5.Text = p.Inseam.ToString();
        }

        public void drawDressShirt()
        {
            DressShirt p = (DressShirt)this.p;
            this.drawSet(true, true, true, true, true, false, false, false);
            this.drawApparel();
            this.lblVar4.Text = "Neck";
            this.txtVar4.Text = p.Neck.ToString();
            this.lblVar5.Text = "Sleeve";
            this.txtVar5.Text = p.Sleeve.ToString();
        }

        public void drawTShirt()
        {
            TShirt p = (TShirt)this.p;
            this.drawSet(true, true, true, true, false, false, false, false);
            this.drawApparel();
            this.lblVar4.Text = "Size";
            this.txtVar4.Text = p.Size.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.idx == 1)
            {
                this.idx = this.idx - 1;
                this.p = this.pl.ElementAt<Product>(this.idx);
                this.drawProduct();
                this.btnPrevious.Enabled = false;
            }
            else
            {
                this.idx = this.idx - 1;
                this.p = this.pl.ElementAt<Product>(this.idx);
                this.drawProduct();
                this.btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.idx == this.pl.Count - 2)
            {
                this.idx = this.idx + 1;
                this.p = this.pl.ElementAt<Product>(this.idx);
                this.drawProduct();
                this.btnNext.Enabled = false;
            }
            else
            {
                if (this.idx >= this.pl.Count - 2)
                    return;
                this.idx = this.idx + 1;
                this.p = this.pl.ElementAt<Product>(this.idx);
                this.drawProduct();
                this.btnPrevious.Enabled = true;
            }
        }

        private void btnReadBin_Click(object sender, EventArgs e)
        {
            this.pl.Clear();
            this.pl.readFromBinary("Products.bin");
            this.idx = 0;
            this.drawProduct();
            this.btnPrevious.Enabled = false;
            this.btnNext.Enabled = true;
            this.btnWrite.Enabled = true;
            this.btnWriteBin.Enabled = true;
        }

        private void btnWriteBin_Click(object sender, EventArgs e)
        {
            this.pl.writeToBinary("Output.bin");
        }

        private void InitializeComponent()
        {
            this.btnRead = new Button();
            this.btnExit = new Button();
            this.btnWrite = new Button();
            this.btnPrevious = new Button();
            this.btnNext = new Button();
            this.lblType = new Label();
            this.txtType = new TextBox();
            this.txtID = new TextBox();
            this.lblID = new Label();
            this.txtDesc = new TextBox();
            this.lblDesc = new Label();
            this.txtPrice = new TextBox();
            this.lblPrice = new Label();
            this.txtQuantity = new TextBox();
            this.lblQuantity = new Label();
            this.txtVar1 = new TextBox();
            this.lblVar1 = new Label();
            this.txtVar2 = new TextBox();
            this.lblVar2 = new Label();
            this.txtVar3 = new TextBox();
            this.lblVar3 = new Label();
            this.txtVar4 = new TextBox();
            this.lblVar4 = new Label();
            this.txtVar5 = new TextBox();
            this.lblVar5 = new Label();
            this.txtVar6 = new TextBox();
            this.lblVar6 = new Label();
            this.txtVar7 = new TextBox();
            this.lblVar7 = new Label();
            this.txtVar8 = new TextBox();
            this.lblVar8 = new Label();
            this.btnWriteBin = new Button();
            this.btnReadBin = new Button();
            this.SuspendLayout();
            this.btnRead.Location = new Point(12, 364);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new EventHandler(this.btnRead_Click);
            this.btnExit.Location = new Point(237, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.btnWrite.Location = new Point(93, 364);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new Size(75, 23);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new EventHandler(this.btnWrite_Click);
            this.btnPrevious.Location = new Point(12, 394);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new EventHandler(this.btnPrevious_Click);
            this.btnNext.Location = new Point(93, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new EventHandler(this.btnNext_Click);
            this.lblType.AutoSize = true;
            this.lblType.Location = new Point(9, 21);
            this.lblType.Name = "lblType";
            this.lblType.Size = new Size(31, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            this.txtType.Location = new Point(95, 18);
            this.txtType.Name = "txtType";
            this.txtType.Size = new Size(217, 20);
            this.txtType.TabIndex = 7;
            this.txtID.Location = new Point(95, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new Size(217, 20);
            this.txtID.TabIndex = 9;
            this.lblID.AutoSize = true;
            this.lblID.Location = new Point(9, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new Size(18, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            this.txtDesc.Location = new Point(95, 70);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new Size(217, 20);
            this.txtDesc.TabIndex = 11;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new Point(11, 73);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new Size(60, 13);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Description";
            this.txtPrice.Location = new Point(95, 96);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new Size(217, 20);
            this.txtPrice.TabIndex = 13;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new Point(9, 99);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new Size(31, 13);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            this.txtQuantity.Location = new Point(95, 122);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new Size(217, 20);
            this.txtQuantity.TabIndex = 15;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new Point(9, 125);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new Size(46, 13);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity";
            this.txtVar1.Location = new Point(95, 148);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new Size(217, 20);
            this.txtVar1.TabIndex = 17;
            this.lblVar1.AutoSize = true;
            this.lblVar1.Location = new Point(9, 151);
            this.lblVar1.Name = "lblVar1";
            this.lblVar1.Size = new Size(29, 13);
            this.lblVar1.TabIndex = 16;
            this.lblVar1.Text = "Var1";
            this.txtVar2.Location = new Point(95, 174);
            this.txtVar2.Name = "txtVar2";
            this.txtVar2.Size = new Size(217, 20);
            this.txtVar2.TabIndex = 19;
            this.lblVar2.AutoSize = true;
            this.lblVar2.Location = new Point(9, 177);
            this.lblVar2.Name = "lblVar2";
            this.lblVar2.Size = new Size(29, 13);
            this.lblVar2.TabIndex = 18;
            this.lblVar2.Text = "Var2";
            this.txtVar3.Location = new Point(95, 200);
            this.txtVar3.Name = "txtVar3";
            this.txtVar3.Size = new Size(217, 20);
            this.txtVar3.TabIndex = 21;
            this.lblVar3.AutoSize = true;
            this.lblVar3.Location = new Point(9, 203);
            this.lblVar3.Name = "lblVar3";
            this.lblVar3.Size = new Size(29, 13);
            this.lblVar3.TabIndex = 20;
            this.lblVar3.Text = "Var3";
            this.txtVar4.Location = new Point(95, 226);
            this.txtVar4.Name = "txtVar4";
            this.txtVar4.Size = new Size(217, 20);
            this.txtVar4.TabIndex = 23;
            this.lblVar4.AutoSize = true;
            this.lblVar4.Location = new Point(9, 229);
            this.lblVar4.Name = "lblVar4";
            this.lblVar4.Size = new Size(29, 13);
            this.lblVar4.TabIndex = 22;
            this.lblVar4.Text = "Var4";
            this.txtVar5.Location = new Point(95, 252);
            this.txtVar5.Name = "txtVar5";
            this.txtVar5.Size = new Size(217, 20);
            this.txtVar5.TabIndex = 25;
            this.lblVar5.AutoSize = true;
            this.lblVar5.Location = new Point(9, (int)byte.MaxValue);
            this.lblVar5.Name = "lblVar5";
            this.lblVar5.Size = new Size(29, 13);
            this.lblVar5.TabIndex = 24;
            this.lblVar5.Text = "Var5";
            this.txtVar6.Location = new Point(95, 278);
            this.txtVar6.Name = "txtVar6";
            this.txtVar6.Size = new Size(217, 20);
            this.txtVar6.TabIndex = 27;
            this.lblVar6.AutoSize = true;
            this.lblVar6.Location = new Point(9, 281);
            this.lblVar6.Name = "lblVar6";
            this.lblVar6.Size = new Size(29, 13);
            this.lblVar6.TabIndex = 26;
            this.lblVar6.Text = "Var6";
            this.txtVar7.Location = new Point(95, 304);
            this.txtVar7.Name = "txtVar7";
            this.txtVar7.Size = new Size(217, 20);
            this.txtVar7.TabIndex = 29;
            this.lblVar7.AutoSize = true;
            this.lblVar7.Location = new Point(9, 307);
            this.lblVar7.Name = "lblVar7";
            this.lblVar7.Size = new Size(29, 13);
            this.lblVar7.TabIndex = 28;
            this.lblVar7.Text = "Var7";
            this.txtVar8.Location = new Point(95, 330);
            this.txtVar8.Name = "txtVar8";
            this.txtVar8.Size = new Size(217, 20);
            this.txtVar8.TabIndex = 31;
            this.lblVar8.AutoSize = true;
            this.lblVar8.Location = new Point(9, 333);
            this.lblVar8.Name = "lblVar8";
            this.lblVar8.Size = new Size(29, 13);
            this.lblVar8.TabIndex = 30;
            this.lblVar8.Text = "Var8";
            this.btnWriteBin.Location = new Point(93, 423);
            this.btnWriteBin.Name = "btnWriteBin";
            this.btnWriteBin.Size = new Size(75, 23);
            this.btnWriteBin.TabIndex = 35;
            this.btnWriteBin.Text = "Write Bin";
            this.btnWriteBin.UseVisualStyleBackColor = true;
            this.btnWriteBin.Click += new EventHandler(this.btnWriteBin_Click);
            this.btnReadBin.Location = new Point(12, 423);
            this.btnReadBin.Name = "btnReadBin";
            this.btnReadBin.Size = new Size(75, 23);
            this.btnReadBin.TabIndex = 34;
            this.btnReadBin.Text = "Read Bin";
            this.btnReadBin.UseVisualStyleBackColor = true;
            this.btnReadBin.Click += new EventHandler(this.btnReadBin_Click);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(322, 461);
            this.Controls.Add((Control)this.btnWriteBin);
            this.Controls.Add((Control)this.btnReadBin);
            this.Controls.Add((Control)this.txtVar8);
            this.Controls.Add((Control)this.lblVar8);
            this.Controls.Add((Control)this.txtVar7);
            this.Controls.Add((Control)this.lblVar7);
            this.Controls.Add((Control)this.txtVar6);
            this.Controls.Add((Control)this.lblVar6);
            this.Controls.Add((Control)this.txtVar5);
            this.Controls.Add((Control)this.lblVar5);
            this.Controls.Add((Control)this.txtVar4);
            this.Controls.Add((Control)this.lblVar4);
            this.Controls.Add((Control)this.txtVar3);
            this.Controls.Add((Control)this.lblVar3);
            this.Controls.Add((Control)this.txtVar2);
            this.Controls.Add((Control)this.lblVar2);
            this.Controls.Add((Control)this.txtVar1);
            this.Controls.Add((Control)this.lblVar1);
            this.Controls.Add((Control)this.txtQuantity);
            this.Controls.Add((Control)this.lblQuantity);
            this.Controls.Add((Control)this.txtPrice);
            this.Controls.Add((Control)this.lblPrice);
            this.Controls.Add((Control)this.txtDesc);
            this.Controls.Add((Control)this.lblDesc);
            this.Controls.Add((Control)this.txtID);
            this.Controls.Add((Control)this.lblID);
            this.Controls.Add((Control)this.txtType);
            this.Controls.Add((Control)this.lblType);
            this.Controls.Add((Control)this.btnNext);
            this.Controls.Add((Control)this.btnPrevious);
            this.Controls.Add((Control)this.btnWrite);
            this.Controls.Add((Control)this.btnExit);
            this.Controls.Add((Control)this.btnRead);
            this.Name = "frmMain";
            this.Text = "Products";
            this.Load += new EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
