using System;
using System.Collections.Generic;

class NineGagNumbers
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();

        Console.WriteLine(ConvertToDecimal(number));
    }

    private static ulong ConvertToDecimal(string number)
    {
        Stack<int> numbersFromGags = new Stack<int>();

        for (int i = 0; i < number.Length; i++)
        {
            string currentLetter = number.Substring(0, i + 1);

            if (GetNumberFromGag(currentLetter) != -1)
            {
                numbersFromGags.Push(GetNumberFromGag(currentLetter));
                number = number.Remove(0, currentLetter.Length);
                i = 0;
            }
        }

        ulong finalNumber = 0;
        ulong baseValue = 1;

        while (numbersFromGags.Count > 0)
        {
            finalNumber += (ulong)numbersFromGags.Pop() * baseValue;
            baseValue *= 9;
        }

        return finalNumber;
    }

    static int GetNumberFromGag(string gag)
    {
        int number = -1;

        switch (gag)
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