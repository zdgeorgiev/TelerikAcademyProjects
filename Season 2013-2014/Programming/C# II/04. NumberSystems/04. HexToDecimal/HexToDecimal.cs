using System;

public class HexToDecimal
{
    public const int HexBaseValue = 16;

    public static int ConvertToDecimal(string hex)
    {
        char[] hexArray = hex.ToCharArray();
        int number = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            number += GetNumberFromString(hexArray[hexArray.Length - 1 - i].ToString())
                * (int)Math.Pow(HexBaseValue, i);
        }

        return number;
    }

    private static int GetNumberFromString(string digit)
    {
        int number = 0;

        switch (digit)
        {
            case "0": number = 0; break;
            case "1": number = 1; break;
            case "2": number = 2; break;
            case "3": number = 3; break;
            case "4": number = 4; break;
            case "5": number = 5; break;
            case "6": number = 6; break;
            case "7": number = 7; break;
            case "8": number = 8; break;
            case "9": number = 9; break;
            case "A": number = 10; break;
            case "B": number = 11; break;
            case "C": number = 12; break;
            case "D": number = 13; break;
            case "E": number = 14; break;
            case "F": number = 15; break;
            default:
                throw new ArgumentException("Invalid digit");
        }

        return number;
    }

    static void Main(string[] args)
    {
        string hexValue = "8FFF";

        Console.WriteLine(ConvertToDecimal(hexValue));
    }
}

//Write a program to convert hexadecimal numbers to their decimal representation.