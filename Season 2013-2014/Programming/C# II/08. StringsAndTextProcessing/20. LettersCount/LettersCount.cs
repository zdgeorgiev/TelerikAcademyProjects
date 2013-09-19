using System;
using System.Text;
using System.Linq;

class LettersCount
{
    static void Main(string[] args)
    {
        string text = "AAAAa bb dddddddd aaaaaaaa qqqqqq vvvvvvvv";
        string[] allWords = text.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        int[] lettersCount = new int[26];

        for (int i = 0; i < allWords.Length; i++)
        {
            string currentWord = allWords[i].ToUpper();

            for (int j = 0; j < currentWord.Length; j++)
            {
                lettersCount[(int)currentWord[j] - 65]++;
            }
        }

        string result = string.Empty;
        result = GetAllLettersCount(lettersCount);

        Console.WriteLine(result);
    }

    static string GetAllLettersCount(int[] lettersCount)
    {
        StringBuilder allLetters = new StringBuilder();

        for (int i = 0; i < lettersCount.Length; i++)
        {
            if (lettersCount[i] > 0)
            {
                allLetters.AppendLine((char)(65 + i) + " - " + lettersCount[i].ToString());
            } 
        }

        return allLetters.ToString();
    }
}

//Write a program that reads a string from the console and prints all
//different letters in the string along with information how many times each letter is found.