﻿using System;

class NumbersNotDevidebleTo3And7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i%3==0 && i%7==0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
