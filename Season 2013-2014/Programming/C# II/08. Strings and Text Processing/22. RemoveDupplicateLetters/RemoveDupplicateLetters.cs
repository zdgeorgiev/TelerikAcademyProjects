using System;
using System.Text;

class RemoveDupplicateLetters
{
    static void Main(string[] args)
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        bool[] avaibleLetter = new bool[26];
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char currentLetter = char.Parse(text[i].ToString().ToUpper());

            while (!avaibleLetter[(int)currentLetter - 65])
            {
                avaibleLetter = new bool[26];
                avaibleLetter[(int)currentLetter - 65] = true;
                result.Append(currentLetter);
            }
        }

        Console.WriteLine(result.ToString().ToLower());
    }
}

//Write a program that reads a string from the
//console and replaces all series of consecutive
//identical letters with a single one. Example:
//"aaaaabbbbbcdddeeeedssaa"  "abcdedsa".