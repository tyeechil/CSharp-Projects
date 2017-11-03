using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Addrbtn.Checked = true;
            matrixA = new Matrix2();
            matrixB = new Matrix2();
            matrixC = new Matrix2();
            MatARow.Text = 3 + "";
            MatACol.Text = 3 + "";
            MatBRow.Text = 3 + "";
            MatBCol.Text = 3 + "";
        }
        int rowc, colc;

        //double[,] matrixA;
        //double[,] matrixB;
        //double[,] matrixC;
        Matrix2 matrixA;
        Matrix2 matrixB;
        Matrix2 matrixC;


        Random random = new Random();

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            MatAtxt.Clear();
            MatBtxt.Clear();
            MatCtxt.Clear();
        }

        private void BIdentbtn_Click(object sender, EventArgs e)
        {
            MatBtxt.Clear();
            matrixB = Matrix2.makeID(Convert.ToInt32(MatBCol.Text));
            MatBtxt.Text = matrixB.ToString();
            
        }

        double d;

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            MatCtxt.Clear();
            if (Convert.ToInt32(MatARow.Text) > Convert.ToInt32(MatBRow.Text))
            {
                rowc = Convert.ToInt32(MatARow.Text);
            }
            else
            {
                rowc = Convert.ToInt32(MatBRow.Text);
            }
            if (Convert.ToInt32(MatACol.Text) > Convert.ToInt32(MatBCol.Text))
            {
                colc = Convert.ToInt32(MatACol.Text);
            }
            else
            {
                colc = Convert.ToInt32(MatBCol.Text);
            }

            if (Multiplyrbtn.Checked)
            {
                matrixC = matrixA * matrixB;
                MatCtxt.Text = matrixC.ToString();
            }
            else if (Addrbtn.Checked)
            {
                matrixC = matrixA * matrixB;
                MatCtxt.Text = matrixC.ToString();
            }
            else if (Subtractrbtn.Checked)
            {
                matrixC = matrixA - matrixB;
                MatCtxt.Text = matrixC.ToString();

            }
            else if (Equalrbtn.Checked)
            {
                if (matrixA == matrixB)
                {
                    MatCtxt.Text = "A is equal to B";
                }
                else
                {
                    MatCtxt.Text = "A is not equal to B";
                }
            }
            else
            {
                MessageBox.Show("Please Select an Operation");
            }
        }

        private void MatAbtn_Click(object sender, EventArgs e)
        {
            MatAtxt.Clear();
            matrixA = new Matrix2(Convert.ToInt32(MatARow.Text), Convert.ToInt32(MatACol.Text));
            MatAtxt.Text = matrixA.ToString();
        }

        private void MatBbtn_Click(object sender, EventArgs e)
        {
            MatBtxt.Clear();
            matrixB = new Matrix2(Convert.ToInt32(MatBRow.Text), Convert.ToInt32(MatBCol.Text));
            MatBtxt.Text = matrixB.ToString();
        }

        private void BcopyAbtn_Click(object sender, EventArgs e)
        {
            MatBtxt.Clear();
            if (MatAtxt.Text != "" || MatBtxt.Text != "")
            {
                matrixB.clone(matrixA);
            }
            else
            {
                MessageBox.Show("B and/or A has not been initalize yet");
            }
            MatBtxt.Text = matrixB.ToString();
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            d = random.NextDouble() * (maximum - minimum) + minimum;
            d = Math.Round(d, 1);
            return d;
        }
    }
}
