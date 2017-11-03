using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixOps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MatARow.Text = "3";
            MatACol.Text = "3";
            MatBCol.Text = "3";
            MatBRow.Text = "3";
        }
        int rowa, cola, rowb, colb,rowc,colc;
        double[,] matrixA;
        double[,] matrixB;
        double[,] matrixC;
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
            for (int i = 0; i < rowb; i++)
            {
                for (int j = 0; j < colb; j++)
                    if (i == j)
                    {
                        matrixB[i, j] = 1.0;
                    }
                else
                    {
                        matrixB[i, j] = 0.0;
                    }
            }
            //print
            //i = row, j = column
            for (int i = 0; i < rowb; i++)
            {
                for (int j = 0; j < colb; j++)
                {
                    MatBtxt.AppendText(string.Format("{0}   ", matrixB[i, j]));
                }
                MatBtxt.AppendText(Environment.NewLine + Environment.NewLine);
            }
        }

        double d;

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            MatCtxt.Clear();
            if (rowa>rowb) {
                rowc = rowa;
            }
            else {
                rowc = rowb;
            }
            if (cola > colb) {
                colc = cola;
            }
            else
            {
                colc = colb;
            }
            matrixC = new double[rowc, colc];
            if (Multiplyrbtn.Checked) {
                for (int i = 0; i < rowc; i++)
                {
                    for (int j = 0; j < colc; j++)
                    {
                        matrixC[i, j] = matrixA[i, j] * matrixB[i, j];
                    }
                }
                //print
                for (int i = 0; i < rowc; i++)
                {
                    for (int j = 0; j < colc; j++)
                    {
                        MatCtxt.AppendText(string.Format("{0}   ", matrixC[i, j]));
                    }
                    MatCtxt.AppendText(Environment.NewLine + Environment.NewLine);
                }
            }
            else if (Addrbtn.Checked) {
                for (int i = 0; i < rowc; i++)
                {
                    for (int j = 0; j < colc; j++)
                    {
                        matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    }
                }
                //print
                for (int i = 0; i < rowc; i++)
                {
                    for (int j = 0; j < colc; j++)
                    {
                        MatCtxt.AppendText(string.Format("{0}   ", matrixC[i, j]));
                    }
                    MatCtxt.AppendText(Environment.NewLine + Environment.NewLine);
                }
            }
            else if (Subtractrbtn.Checked) {
                for (int i = 0; i < rowa; i++)
                {
                    for (int j = 0; j < cola; j++)
                    {
                        matrixC[i, j] = matrixA[i, j] - matrixB[i, j];
                    }
                }
                //print
                for (int i = 0; i < rowa; i++)
                {
                    for (int j = 0; j < cola; j++)
                    {
                        MatCtxt.AppendText(string.Format("{0}   ", matrixC[i, j]));
                    }
                    MatCtxt.AppendText(Environment.NewLine + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Please Select an Operation");
            }
        }

        private void MatAbtn_Click(object sender, EventArgs e)
        {
            d = 0;
            MatAtxt.Clear();
            rowa = Convert.ToInt32(MatARow.Text);
            cola = Convert.ToInt32(MatACol.Text);
            matrixA = new double[rowa, cola];
            //populate matrix
            for (int i = 0; i < rowa; i++)
            {
                for (int j = 0; j < cola; j++)
                    matrixA[i, j] = GetRandomNumber(0.0, 9.9);
            }
            //print
            //i = row, j = column
            for (int i = 0; i < rowa; i++)
            {
                for (int j = 0; j < cola; j++)
                {
                    MatAtxt.AppendText(string.Format("{0}   ", matrixA[i, j]));
                }
                MatAtxt.AppendText(Environment.NewLine + Environment.NewLine);
            }
        }

        private void MatBbtn_Click(object sender, EventArgs e)
        {
            d = 0;
            MatBtxt.Clear();
            rowb = Convert.ToInt32(MatBRow.Text);
            colb = Convert.ToInt32(MatBCol.Text);
            matrixB = new double[rowb, colb];
            //populate matrix
            for (int i = 0; i < rowb; i++)
            {
                for (int j = 0; j < colb; j++)
                    matrixB[i, j] = GetRandomNumber(0.0, 9.9);
            }
            //print
            //i = row, j = column
            for (int i = 0; i < rowb; i++)
            {
                for (int j = 0; j < colb; j++)
                {
                    MatBtxt.AppendText(string.Format("{0}   ", matrixB[i, j]));
                }
                MatBtxt.AppendText(Environment.NewLine + Environment.NewLine);
            }
        }
        //Generate Double
        public double GetRandomNumber(double minimum, double maximum)
        {
            d = random.NextDouble() * (maximum - minimum) + minimum;
            d = Math.Round(d, 1);
            return d;
        }
    }
}
