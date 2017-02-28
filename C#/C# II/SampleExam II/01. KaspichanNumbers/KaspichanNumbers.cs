using System;
using System.Collections.Generic;

class KaspichanNumbers
{
    static string[] allNumbers = new string[256];

    static void Main(string[] args)
    {
        InitializeTheNumbers();

        ulong n = ulong.Parse(Console.ReadLine());

        Console.WriteLine(GetTheNumbers(n));
    }

    private static string GetTheNumbers(ulong n)
    {
        if (n <= 255)
        {
            return allNumbers[n];
        }
        else
        {
            Stack<ulong> currentNumbers = new Stack<ulong>();

            while (n > 0)
            {
                currentNumbers.Push(n % 256);
                n /= 256;
            }

            string finalNumber = string.Empty;

            while (currentNumbers.Count > 0)
            {
                finalNumber += allNumbers[currentNumbers.Pop()];
            }

            return finalNumber;
        }
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