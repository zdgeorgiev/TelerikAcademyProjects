using System;

class CompareFloatingPoints
{
    static void Main(string[] args)
    {
        decimal firstValue = 5.3M;
        decimal secondValue = 6.01M;

        Console.WriteLine((float)firstValue == (float)secondValue);

        decimal firstValue2 = 5.00000001M;
        decimal secondValue2 = 5.00000003M;

        Console.WriteLine((float)firstValue2 == (float)secondValue2);
    }
}

//Write a program that safely compares floating-point numbers
//with precision of 0.000001. Examples:(5.3 ; 6.01)  false;
//(5.00000001 ; 5.00000003)  true