using System;
using System.Text;

public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    public readonly int row;
    public readonly int col;
    private T[,] matrix;

    public Matrix(int row = 5, int col = 5)
    {
        if (row > 0 && col > 0)
        {
            this.row = row;
            this.col = col;
            matrix = new T[row, col];
        }
        else
        {
            throw new IndexOutOfRangeException("Invalid index");
        }
    }

    public T this[int row, int col]
    {
        get
        {
            if (row > this.row || col > this.col || row < 0 || col < 0)
            {
                throw new IndexOutOfRangeException("That col/row doesnt exist in the matrix");
            }
            return this.matrix[row, col];
        }

        set
        {
            if (row >= 0 && col >= 0)
            {
                this.matrix[row, col] = value;
            }
        }
    }

    public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        if (firstMatrix.col == secondMatrix.col && firstMatrix.row == secondMatrix.row)
        {
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.row, firstMatrix.col);

            for (int row = 0; row < firstMatrix.row; row++)
            {
                for (int col = 0; col < firstMatrix.col; col++)
                {
                    dynamic firstValue = firstMatrix[row, col];
                    dynamic secondValue = secondMatrix[row, col];
                    newMatrix[row, col] = firstValue + secondValue;
                }
            }
            return newMatrix;
        }
        else
        {
            throw new ArgumentException("The matrix's isnt the same size");
        }
    }

    public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        if (firstMatrix.col == secondMatrix.col && firstMatrix.row == secondMatrix.row)
        {
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.row, firstMatrix.col);

            for (int row = 0; row < firstMatrix.row; row++)
            {
                for (int col = 0; col < firstMatrix.col; col++)
                {
                    dynamic firstValue = firstMatrix[row, col];
                    dynamic secondValue = secondMatrix[row, col];
                    newMatrix[row, col] = firstValue - secondValue;
                }
            }
            return newMatrix;
        }
        else
        {
            throw new ArgumentException("The matrix's isnt the same size");
        }
    }

    public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        if (firstMatrix.col == secondMatrix.col && firstMatrix.row == secondMatrix.row)
        {
            Matrix<T> newMatrix = new Matrix<T>();

            for (int row = 0; row < firstMatrix.row; row++)
            {
                for (int col = 0; col < firstMatrix.col; col++)
                {
                    dynamic sum = 0;
                    for (int x = 0; x < col; x++)
                    {
                        sum = sum + (dynamic)firstMatrix.matrix[row, x] * (dynamic)secondMatrix.matrix[x, col];
                    }
                    newMatrix[row, col] = sum;
                }
            }
            return newMatrix;
        }
        else
        {
            throw new ArgumentException("The matrix's isnt the same size");
        }
    }

    //Implement the true operator (check for non-zero elements).
    public static bool operator true(Matrix<T> matrix)
    {
        dynamic zero = 0;

        for (int row = 0; row < matrix.row; row++)
        {
            for (int col = 0; col < matrix.col; col++)
            {
                if (matrix[row, col] == zero)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        dynamic zero = 0;

        for (int row = 0; row < matrix.row; row++)
        {
            for (int col = 0; col < matrix.col; col++)
            {
                if (matrix[row, col] == zero)
                {
                    return true;
                }
            }
        }
        return false;
    }
}