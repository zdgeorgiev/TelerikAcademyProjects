using System;
using System.Collections.Generic;

class CheckPrime
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool prime = true;
        for (int a = 2; a < Math.Sqrt(number); a++)
        {
            if (number % a == 0)
            {
                prime = false;
                break;
            }
        }
        Console.WriteLine(prime);
    }
} 

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.