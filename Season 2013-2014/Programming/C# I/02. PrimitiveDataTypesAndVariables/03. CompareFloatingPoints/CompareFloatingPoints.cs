using System;

class CompareFloatingPoints
{
    static void Main(string[] args)
    {
        Console.WriteLine(5.3f == 6.01f);

        decimal firstValue = Math.Round(5.00000001M, 7);
        decimal secondValue = Math.Round(5.00000003M, 7);

        Console.WriteLine(firstValue == secondValue);
    }
}

//Write a program that safely compares floating-point numbers
//with precision of 0.000001. Examples:(5.3 ; 6.01)  false;
//(5.00000001 ; 5.00000003)  true