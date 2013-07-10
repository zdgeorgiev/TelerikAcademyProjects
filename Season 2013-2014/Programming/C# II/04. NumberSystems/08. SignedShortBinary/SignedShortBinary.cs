using System;
using System.Collections.Generic;

class SignedShortBinary
{
    public const int BinaryBaseValue = 2;

    public static string ConvertToBinary(short number)
    {
        List<int> convertedNumber = new List<int>();

        if (number > 0)
        {

            while (number > 0)
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
        else
        {
            //Get the number that from maxValue subtract the negative number + 1
            short positiveNumber = (short)(short.MaxValue + number + 1);
            //Set the first bit 1 because its negative number
            string finalBits = "1" + ConvertToBinary(positiveNumber);

            return finalBits;
        }
    }

    static void Main(string[] args)
    {
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine(ConvertToBinary(number));
    }
}

//Write a program that shows the binary representation of 
//given 16-bit signed integer number (the C# type short).