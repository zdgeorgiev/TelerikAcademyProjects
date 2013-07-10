using System;
using System.Text;

public class Matrix
{
    public int Rows { get; set; }
    public int Cols { get; set; }
    private int[,] matrix;

    public Matrix(int rows, int cols)
    {
        this.Rows = rows;
        this.Cols = cols;
        this.matrix = new int[Rows, Cols];
    }

    public int this[int rows, int cols]
    {
        get
        {
            if (rows < 0 || rows > this.Rows)
            {
                throw new ArgumentException("Sorry index for rows is invalid");
            }
            if (cols < 0 || cols > this.Cols)
            {
                throw new ArgumentException("Sorry but index for cols is invalid");
            }

            return this.matrix[rows, cols];
        }
        set
        {
            if (rows < 0 || rows > this.Rows)
            {
                throw new ArgumentException("Sorry index for rows is invalid");
            }
            if (cols < 0 || cols > this.Cols)
            {
                throw new ArgumentException("Sorry but index for cols is invalid");
            }

            this.matrix[rows, cols] = value;
        }
    }

    public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
    {
        if (firstMatrix.Cols != secondMatrix.Cols &&
            firstMatrix.Rows != secondMatrix.Rows)
        {
            throw new ArgumentException(
                "Sorry but for adding method the matrices should be with same rows and cols");
        }

        Matrix newMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                newMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
            }
        }

        return newMatrix;
    }

    public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
    {
        if (firstMatrix.Cols != secondMatrix.Cols &&
            firstMatrix.Rows != secondMatrix.Rows)
        {
            throw new ArgumentException(
                "Sorry but for subtract method the matrices should be with same rows and cols");
        }

        Matrix newMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                newMatrix[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
            }
        }

        return newMatrix;
    }

    public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
    {
        if (firstMatrix.Cols != secondMatrix.Cols &&
               firstMatrix.Rows != secondMatrix.Rows)
        {
            throw new ArgumentException(
                "Sorry but for multiplying method the matrices should be with same rows and cols");
        }

        Matrix newMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < newMatrix.Rows; row++)
        {
            for (int col = 0; col < newMatrix.Cols; col++)
            {
                for (int multiCol = 0; multiCol < firstMatrix.Cols; multiCol++)
                {
                    for (int k = 0; k < firstMatrix.Cols; k++)
                    {
                        newMatrix[row, col] += firstMatrix[row, k] * secondMatrix[k, col];
                    }
                }
            }
        }

        return newMatrix;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        for (int row = 0; row < this.matrix.GetLength(0); row++)
        {
            result.Append("{ ");

            for (int col = 0; col < this.matrix.GetLength(1); col++)
            {
                result.AppendFormat("{0,4}", this.matrix[row, col] + ", ");
            }

            result.Length -= 2;
            result.Append(" }");
            result.AppendLine();
        }

        return result.ToString();
    }
}