using System;

public class HexToBinary
{
    public static string ConvertToBinary(string hex)
    {
        char[] hexArray = hex.ToCharArray();

        string result = string.Empty;

        for (int i = 0; i < hexArray.Length; i++)
        {
            result += DigitAsBits(hexArray[i].ToString());
        }

        //Remove leading zeros
        var finalBits = result.TrimStart('0');

        return finalBits;
    }

    private static string DigitAsBits(string digit)
    {
        string bits = string.Empty;

        switch (digit)
        {
            case "0": bits = "0000"; break;
            case "1": bits = "0001"; break;
            case "2": bits = "0010"; break;
            case "3": bits = "0011"; break;
            case "4": bits = "0100"; break;
            case "5": bits = "0101"; break;
            case "6": bits = "0110"; break;
            case "7": bits = "0111"; break;
            case "8": bits = "1000"; break;
            case "9": bits = "1001"; break;
            case "A": bits = "1010"; break;
            case "B": bits = "1011"; break;
            case "C": bits = "1100"; break;
            case "D": bits = "1101"; break;
            case "E": bits = "1110"; break;
            case "F": bits = "1111"; break;
            default:
                break;
        }

        return bits;
    }

    static void Main(string[] args)
    {
        string hexValue = "1F4";

        Console.WriteLine(ConvertToBinary(hexValue));
    }
}

//Write a program to convert hexadecimal numbers to binary numbers (directly).