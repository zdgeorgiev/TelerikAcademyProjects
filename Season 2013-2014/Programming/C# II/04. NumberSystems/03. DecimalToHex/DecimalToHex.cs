using System;
using System.Collections.Generic;

public class DecimalToHex
{
    public const int HexBaseValue = 16;

    public static string ConvertToHex(int number)
    {
        List<string> convertedNumber = new List<string>();

        while (number > 0)
        {
            int remainder = number % HexBaseValue;
            convertedNumber.Add(FindDigitInHexFormat(remainder));
            number /= HexBaseValue;
        }

        //Reverse the order of the remainders
        convertedNumber.Reverse();

        string convertedString = string.Empty;

        foreach (var reminder in convertedNumber)
        {
            convertedString += reminder;
        }

        return convertedString;
    }

    private static string FindDigitInHexFormat(int digit)
    {
        string digitString = string.Empty;

        switch (digit)
        {
            case 0: digitString = "0"; break;
            case 1: digitString = "1"; break;
            case 2: digitString = "2"; break;
            case 3: digitString = "3"; break;
            case 4: digitString = "4"; break;
            case 5: digitString = "5"; break;
            case 6: digitString = "6"; break;
            case 7: digitString = "7"; break;
            case 8: digitString = "8"; break;
            case 9: digitString = "9"; break;
            case 10: digitString = "A"; break;
            case 11: digitString = "B"; break;
            case 12: digitString = "C"; break;
            case 13: digitString = "D"; break;
            case 14: digitString = "E"; break;
            case 15: digitString = "F"; break;
            default:
                throw new ArgumentException("Invalid digit");
        }

        return digitString;
    }

    static void Main(string[] args)
    {
        int number = 5040;

        Console.WriteLine(ConvertToHex(number));
    }
}

//Write a program to convert decimal numbers to their hexadecimal representation.