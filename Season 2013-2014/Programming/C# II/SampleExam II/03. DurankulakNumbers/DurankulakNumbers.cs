using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class DurankulakNumbers
{
    static string[] allNumbers = new string[168];

    static void Main(string[] args)
    {
        InitializeTheNumbers();

        Console.WriteLine(ConvertToDecimal(Console.ReadLine()));
    }

    private static BigInteger ConvertToDecimal(string numberLetters)
    {
        List<string> tempListNumbers = allNumbers.ToList();

        Stack<string> allLetters = new Stack<string>();

        for (int i = 0; i < numberLetters.Length; i++)
        {
            string currentLetter = numberLetters.Substring(0, 1);

            if (tempListNumbers.Contains(currentLetter))
            {
                allLetters.Push(currentLetter);
                numberLetters = numberLetters.Substring(1);
            }
            else
            {
                allLetters.Push(numberLetters.Substring(0, 2));
                numberLetters = numberLetters.Substring(2);
            }

            i = -1;
        }

        BigInteger baseValue = 1;
        BigInteger finalNumber = 0;

        while (allLetters.Count > 0)
        {
            finalNumber += tempListNumbers.IndexOf(allLetters.Pop()) * baseValue;
            baseValue *= 168;
        }

        return finalNumber;
    }

    private static void InitializeTheNumbers()
    {
        for (int i = 0; i < 26; i++)
        {
            allNumbers[i] = ((char)('A' + i)).ToString();
        }

        int currentLetterIndex = 26;

        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (currentLetterIndex == allNumbers.Length)
                {
                    break;
                }

                allNumbers[currentLetterIndex] = ((char)('a' + i)).ToString() + ((char)('A' + j)).ToString();
                currentLetterIndex++;
            }
        }
    }
}