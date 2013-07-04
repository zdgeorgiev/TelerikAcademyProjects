using System;

class ClassMatrix
{
    static void Main(string[] args)
    {
        Matrix matrix = new Matrix(3, 3);
        Matrix matrix2 = new Matrix(3, 3);

        matrix[2, 2] = 5;
        matrix2[2, 2] = 5;

        Console.WriteLine(matrix);
        Console.WriteLine(matrix2);

        Matrix matrix3 = new Matrix(3, 3);

        matrix3 = matrix + matrix2;

        Console.WriteLine(matrix3);
    }
}

//* Write a class Matrix, to holds a matrix of integers. Overload the
//    operators for adding, subtracting and multiplying of matrices,
//    indexer for accessing the matrix content and ToString().