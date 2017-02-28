using System;
using System.Collections.Generic;

class MultiverseCommunication
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();

        Stack<ulong> numbers = new Stack<ulong>();

        for (int i = 0; i < inputString.Length; i++)
        {
            string currentLetter = inputString.Substring(0, 3);

            if (GetTheNumber(currentLetter) != 66)
            {
                numbers.Push(GetTheNumber(currentLetter));
            }

            inputString = inputString.Substring(3);
            i = -1;
        }

        ulong baseValue = 1;
        ulong result = 0;

        while (numbers.Count > 0)
        {
            result += numbers.Pop() * baseValue;
            baseValue *= 13;
        }

        Console.WriteLine(result);
    }

    static ulong GetTheNumber(string str)
    {
        ulong number = 0;

        switch (str)
        {
            case "CHU": number = 0; break;
            case "TEL": number = 1; break;
            case "OFT": number = 2; break;
            case "IVA": number = 3; break;
            case "EMY": number = 4; break;
            case "VNB": number = 5; break;
            case "POQ": number = 6; break;
            case "ERI": number = 7; break;
            case "CAD": number = 8; break;
            case "K-A": number = 9; break;
            case "IIA": number = 10; break;
            case "YLO": number = 11; break;
            case "PLA": number = 12; break;

            default:
                number = 66; break;
        }

        return number;
    }
}