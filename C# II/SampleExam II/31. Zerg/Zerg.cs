using System;
using System.Collections.Generic;

class Zerg
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();

        Stack<ulong> numbers = new Stack<ulong>();

        for (int i = 0; i < inputString.Length; i++)
        {
            string currentLetter = inputString.Substring(0, 4);

            if (GetTheNumber(currentLetter) != 66)
            {
                numbers.Push(GetTheNumber(currentLetter));
            }

            inputString = inputString.Substring(4);
            i = -1;
        }

        ulong baseValue = 1;
        ulong result = 0;

        while (numbers.Count > 0)
        {
            result += numbers.Pop() * baseValue;
            baseValue *= 15;
        }

        Console.WriteLine(result);
    }

    static ulong GetTheNumber(string str)
    {
        ulong number = 0;

        switch (str)
        {
            case "Rawr": number = 0; break;
            case "Rrrr": number = 1; break;
            case "Hsst": number = 2; break;
            case "Ssst": number = 3; break;
            case "Grrr": number = 4; break;
            case "Rarr": number = 5; break;
            case "Mrrr": number = 6; break;
            case "Psst": number = 7; break;
            case "Uaah": number = 8; break;
            case "Uaha": number = 9; break;
            case "Zzzz": number = 10; break;
            case "Bauu": number = 11; break;
            case "Djav": number = 12; break;
            case "Myau": number = 13; break;
            case "Gruh": number = 14; break;

            default:
                number = 66; break;
        }

        return number;
    }
}