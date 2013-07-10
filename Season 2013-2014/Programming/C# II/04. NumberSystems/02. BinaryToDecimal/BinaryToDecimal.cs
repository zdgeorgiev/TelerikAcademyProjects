using System;

public class BinaryToDecimal
{
    public const int BinaryBaseValue = 2;

    public static uint ConvertToDecimal(string binary)
    {
        char[] binaryArray = binary.ToCharArray();
        uint convertedNumber = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            //Get the last bit
            char currentBit = binaryArray[binaryArray.Length - 1 - i];

            if (currentBit == '0')
            {
                continue;
            }
            else
            {
                convertedNumber += (uint)Math.Pow(BinaryBaseValue, i);
            }
        }

        return convertedNumber;
    }

    static void Main(string[] args)
    {
        string binaryNumber = "101110110";

        Console.WriteLine(ConvertToDecimal(binaryNumber));
    }
}

//Write a program to convert binary numbers to their decimal representation.