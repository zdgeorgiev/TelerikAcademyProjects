using System;
using System.Collections.Generic;

public class DecimalToBinary
{
    public const int BinaryBaseValue = 2;

    public static string ConvertToBinary(int number)
    {
        List<int> convertedNumber = new List<int>();

        while(number > 0)
        {
            convertedNumber.Add(number % BinaryBaseValue);
            number /= BinaryBaseValue;
        }

        //Reverse the order of the bits
        convertedNumber.Reverse();

        string convertedString = string.Empty;

        foreach (var bit in convertedNumber)
        {
            convertedString += bit;
        }

        return convertedString;
    }

    static void Main(string[] args)
    {
        int number = 553400;

        Console.WriteLine(ConvertToBinary(number));
    }
}

//Write a program to convert decimal numbers to their binary representation.