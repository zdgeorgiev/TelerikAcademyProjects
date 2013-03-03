using System;

class Program
{
    static void Main()
    {
        Matrix<int> matrix1 = new Matrix<int>();
        matrix1[1, 2] = 5;
        Matrix<int> matrix2 = new Matrix<int>();
        matrix2[1, 2] = 7;
        Console.WriteLine(matrix1 + matrix2);
        Console.WriteLine(matrix2 - matrix1);
        Console.WriteLine(matrix1 * matrix2);
        //Console.WriteLine(matrix1[600, 500]); exception
    }
}