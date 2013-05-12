﻿using System;

class PrintNumbersInInterval
{
    static void Main()
    {
        decimal previousNumer = 0;
        decimal currentNumber = 1;

        decimal nextNumber = 0;

        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine("{0} -> {1}", i, previousNumer);
            nextNumber = previousNumer + currentNumber;
            previousNumer = currentNumber;
            currentNumber = nextNumber;
        }
    }
}

//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
