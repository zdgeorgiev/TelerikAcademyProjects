using System;
using System.Collections.Generic;
using System.Numerics;

class NineGagNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<int> allNumbers = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            string currentNumber = input.Substring(0, i + 1);

            if (GetNumberFromGag(currentNumber) != -1)
            {
                allNumbers.Add(GetNumberFromGag(currentNumber));
                input = input.Remove(0, i + 1);
                i = 0;
            }
        }

        int[] numbs = allNumbers.ToArray();
        BigInteger ninePower = 9;
        BigInteger totalNumber = numbs[numbs.Length - 1];

        for (int i = 1; i < numbs.Length; i++)
        {
            totalNumber += numbs[numbs.Length - 1 - i] * ninePower;
            ninePower *= 9;
        }

        Console.WriteLine(totalNumber);
    }

    static int GetNumberFromGag(string letter)
    {
        int number = 0;

        switch (letter)
        {
            case "-!": number = 0; break;
            case "**": number = 1; break;
            case "!!!": number = 2; break;
            case "&&": number = 3; break;
            case "&-": number = 4; break;
            case "!-": number = 5; break;
            case "*!!!": number = 6; break;
            case "&*!": number = 7; break;
            case "!!**!-": number = 8; break;
            default:
                number = -1; break;
        }

        return number;
    }
}