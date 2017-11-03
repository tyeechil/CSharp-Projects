using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2
{
    class Matrix2
    {
        //Print array that stores the user inputs for validation checking

        int cols;
        int rows;
        private double[,] matrix = null;


        public double this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }


        private int Cols
        {
            get { return cols; }

        }
        private int Rows
        {
            get { return rows; }

        }

        public Matrix2(int x, int y)
        {
            rows = x;
            cols = y;
            matrix = new double[x, y];

            populateRand();
        }
        public Matrix2() { }

        public void clone(Matrix2 copy)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                    matrix[i, j] = copy[i, j];
            }

        }
        public void populateRand()
        {
            Random autoRand = new Random();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrix[i, j] = autoRand.NextDouble() * 10;
                }
            }

        }

        public static Matrix2 makeID(int square)
        {
            Matrix2 matrix = new Matrix2(square, square);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (j == i)
                    {
                        matrix[i, i] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }      
            return matrix;
        }

    private Matrix2 Multiply(Matrix2 input)

    {
        Matrix2 matrixC = new Matrix2(this.Rows, this.Rows);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrixC[i, j] = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                    matrixC[i, j] += this[i, k] * input[k, j];
            }
        }

        return matrixC;
    }
    public bool checkMultiply(int[] arr)
    {
        if (arr[0] != arr[3] || arr[1] != arr[2])
        {

            return false;
        }
        return true;

    }

    public bool checkAddSubtract(int[] arr, string s)
    {
        int compare = Convert.ToInt32(s);
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != compare)
            {
                return false;
            }
        }
        return true;
    }

    public static bool operator ==(Matrix2 firstMatrix, Matrix2 secondMatrix)
    {

        for (int i = 0; i < firstMatrix.Rows; i++)
        {
            for (int j = 0; j < firstMatrix.Cols; j++)
            {
                if (firstMatrix[i, j] != secondMatrix[i, j])
                    return false;
            }
        }
        return true;
    }

    public static bool operator !=(Matrix2 m1, Matrix2 m2)
    {
        return !(m1 == m2);
    }

    public override bool Equals(object o)
    {

        Matrix2 m = (Matrix2)o;

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                if (m[i, j] != matrix[i, j])
                    return false;
            }
        }
        return true;
    }

    public static Matrix2 operator +(Matrix2 matrixA, Matrix2 matrixB)
    {
        return matrixA.Add(matrixB);
    }

    public static Matrix2 operator -(Matrix2 matrixA, Matrix2 matrixB)
    {

        return matrixA.Subtract(matrixB);
    }
    public static Matrix2 operator *(Matrix2 matrixA, Matrix2 matrixB)
    {

        return matrixA.Multiply(matrixB);
    }

    public override int GetHashCode()
    {
        return sum().GetHashCode();
    }

    public double sum()
    {
        double totalSum = 0.0;
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < this.Cols; j++)
                totalSum += matrix[i, j];
        }
        return totalSum;
    }
    private Matrix2 Add(Matrix2 input)
    {
        Matrix2 matrixC = new Matrix2(rows, cols);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrixC[i, j] = this[i, j] + input[i, j];

            }
        }
        return matrixC;

    }

    private Matrix2 Subtract(Matrix2 input)
    {
        Matrix2 matrixC = new Matrix2(rows, cols);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrixC[i, j] = this[i, j] - input[i, j];

            }
        }
        return matrixC;

    }

    public override string ToString()
    {
        string s = "";


        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                s += String.Format("{0:0.0}", matrix[i, j]) + "      ";

            }
            s += Environment.NewLine;
        }
        return s;

    }

}
}
