using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<int> ToBinary = new List<int>();

        while (number > 0)
        {
            ToBinary.Add(number % 2);
            number = number / 2;
        }

        for (int i = 0; i < ToBinary.Count; i++)
        {
            Console.Write(ToBinary[i]);
        }
    }
}

//Write a program to convert decimal numbers to their binary representation.
