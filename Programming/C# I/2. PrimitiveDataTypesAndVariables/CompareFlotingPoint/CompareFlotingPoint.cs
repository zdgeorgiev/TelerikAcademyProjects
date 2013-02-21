using System;

class CompareFlotingPoint
{
    static void Main()
    {
        decimal a = Math.Round(150.00040001M, 6);
        decimal b = Math.Round(150.00300003M, 6);
        Console.WriteLine("First number {0}, Secound number {1}", a, b);
        Console.WriteLine("It is equal - {0}", (a == b));
    }
}

//Write a program that safely compares floating-point numbers with precision of 0.000001.
//Examples:(5.3 ; 6.01)  false;  (6.00000001 ; 5.00000003)  true