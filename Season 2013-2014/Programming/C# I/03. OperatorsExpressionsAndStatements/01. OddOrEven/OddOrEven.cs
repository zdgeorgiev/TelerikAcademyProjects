﻿using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Number {0} is odd.", number);
        }
        else
        {
            Console.WriteLine("Number {0} is even.", number);
        }
    }
}

//Write an expression that checks if given integer is odd or even.