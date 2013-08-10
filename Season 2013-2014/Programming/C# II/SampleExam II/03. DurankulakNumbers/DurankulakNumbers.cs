using System;
using System.Collections.Generic;
using System.Linq;

class DurankulakNumbers
{
    static string[] InitializeTheLetters()
    {
        string[] allLetters = new string[168];

        for (int i = 0; i < 26; i++)
        {
            allLetters[i] = ((char)(65 + i)).ToString();
        }

        int currentPosition = 26;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (currentPosition == 168)
                {
                    return allLetters;
                }

                allLetters[currentPosition] = ((char)(65 + i)).ToString().ToLower()
                    + ((char)(65 + j)).ToString().ToUpper();

                currentPosition++;
            }
        }

        return allLetters;
    }

    static void Main(string[] args)
    {
        string[] allLetters = InitializeTheLetters();

        string number = Console.ReadLine();

        Stack<int> numbers = new Stack<int>();

        for (int i = 0; i < number.Length; i++)
        {
            string currentLetter = number.Substring(0, i + 1);

            if (allLetters.Contains(currentLetter))
            {
                numbers.Push(allLetters.ToList().IndexOf(currentLetter));
                number = number.Remove(0, currentLetter.Length);
                i = -1;
            }
            else
            {
                currentLetter = number.Substring(0, i + 2);
                numbers.Push(allLetters.ToList().IndexOf(currentLetter));
                number = number.Remove(0, currentLetter.Length);
                i = -1;
            }
        }

        ulong result = (ulong)numbers.Pop();
        ulong basePower = 168;

        while (numbers.Count > 0)
        {
            result += (ulong)numbers.Pop() * basePower;
            basePower *= 168;
        }

        Console.WriteLine(result);
    }
}