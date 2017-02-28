using System;

public class BinaryToHex
{
    public static string ConvertToHex(string binary)
    {
        string currentNumber = string.Empty;
        char[] hexArray = binary.ToCharArray();

        if (hexArray.Length % 4 != 0)
        {
            int remainder = hexArray.Length % 4;
            hexArray = (new string('0', remainder) + binary).ToCharArray();
        }

        for (int i = 0; i < binary.Length - 1; i += 4)
        {
            //Get the current fourt bits
            currentNumber += DigitAsBits(
                string.Join("", hexArray[i], hexArray[i + 1], hexArray[i + 2], hexArray[i + 3]).ToString());

        }

        return currentNumber;
    }

    private static string DigitAsBits(string digit)
    {
        string bits = string.Empty;

        switch (digit)
        {
            case "0000": bits = "0"; break;
            case "0001": bits = "1"; break;
            case "0010": bits = "2"; break;
            case "0011": bits = "3"; break;
            case "0100": bits = "4"; break;
            case "0101": bits = "5"; break;
            case "0110": bits = "6"; break;
            case "0111": bits = "7"; break;
            case "1000": bits = "8"; break;
            case "1001": bits = "9"; break;
            case "1010": bits = "A"; break;
            case "1011": bits = "B"; break;
            case "1100": bits = "C"; break;
            case "1101": bits = "D"; break;
            case "1110": bits = "E"; break;
            case "1111": bits = "F"; break;
            default:
                break;
        }

        return bits;
    }

    static void Main(string[] args)
    {
        string binary = "1001111011";

        Console.WriteLine(ConvertToHex(binary));
    }
}

//Write a program to convert binary numbers to hexadecimal numbers (directly).