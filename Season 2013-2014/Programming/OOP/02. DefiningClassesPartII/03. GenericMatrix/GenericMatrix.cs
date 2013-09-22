using System;
using System.Text;

public class GenericMatrix<T>
    where T : IComparable, IConvertible
{
    private int rows;
    private int cols;
    private readonly T[,] allNumbers;

    public GenericMatrix(int row, int col)
    {
        this.Rows = row;
        this.Cols = col;
        this.allNumbers = new T[row, col];
    }

    public T this[int row, int col]
    {
        get { return this.allNumbers[row, col]; }
        set { this.allNumbers[row, col] = value; }
    }

    public static GenericMatrix<T> operator +(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
    {
        if (firstMatrix.Rows != secondMatrix.Rows &&
            firstMatrix.Cols != secondMatrix.Cols)
        {
            throw new ArgumentException("Cannot performe + operator on matrices with different sizes");
        }

        GenericMatrix<T> newMatrix = new GenericMatrix<T>(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                dynamic firstValue = firstMatrix[row, col];
                dynamic secondValue = secondMatrix[row, col];

                newMatrix[row, col] = firstValue + secondValue;
            }
        }

        return newMatrix;
    }

    public static GenericMatrix<T> operator -(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
    {
        if (firstMatrix.Rows != secondMatrix.Rows &&
            firstMatrix.Cols != secondMatrix.Cols)
        {
            throw new ArgumentException("Cannot performe - operator on matrices with different sizes");
        }

        GenericMatrix<T> newMatrix = new GenericMatrix<T>(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                dynamic firstValue = firstMatrix[row, col];
                dynamic secondValue = secondMatrix[row, col];

                newMatrix[row, col] = firstValue - secondValue;
            }
        }

        return newMatrix;
    }

    public static GenericMatrix<T> operator *(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
    {
        GenericMatrix<T> newMatrix = new GenericMatrix<T>(firstMatrix.Rows, secondMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                dynamic sum = 0;

                for (int x = 0; x < col; x++)
                {
                    sum = sum + (dynamic)firstMatrix[row, x] * (dynamic)secondMatrix[x, col];
                }

                newMatrix[row, col] = sum;
            }
        }

        return newMatrix;
    }

    public static bool operator true(GenericMatrix<T> matrix)
    {
        int zero = 0;

        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if (matrix[row, col].CompareTo(zero) == 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static bool operator false(GenericMatrix<T> matrix)
    {
        int zero = 0;

        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if (matrix[row, col].CompareTo(zero) == 0)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public int Rows
    {
        get { return this.rows; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Rows cannot be lessn than 1.");
            }

            this.rows = value;
        }
    }

    public int Cols
    {
        get { return this.cols; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Cols cannot be lessn than 1.");
            }

            this.cols = value;
        }
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Cols; col++)
            {
                output.AppendFormat("{0,3}", this[row,col]);
            }

            output.AppendLine();
        }

        output.Length--;
        return output.ToString();
    }
}