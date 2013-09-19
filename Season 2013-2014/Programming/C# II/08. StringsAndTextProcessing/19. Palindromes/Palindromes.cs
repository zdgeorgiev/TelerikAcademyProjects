using System;
using System.Text;

class Palindromes
{
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        string[] allWords = inputText.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < allWords.Length; i++)
        {
            string normalRepresentation = allWords[i];

            string reversed = string.Empty;

            for (int j = 0; j < normalRepresentation.Length; j++)
            {
                reversed += normalRepresentation[normalRepresentation.Length - j - 1];
            }

            if (normalRepresentation == reversed)
            {
                result.AppendLine(allWords[i]);
            }
        }

        Console.Write(result.ToString());
    }
}

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".