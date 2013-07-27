using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WordsCount
{
    static void Main(string[] args)
    {
        string text = "We are going to going we are planning cards".ToLower();
        string[] allWords = text.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> differentWords = allWords.Distinct().ToList();

        string wordsCount = FindAllDupplicateWords(allWords, differentWords);
        Console.WriteLine(wordsCount);
    }

    static string FindAllDupplicateWords(string[] allWords, List<string> differentWords)
    {
        StringBuilder result = new StringBuilder();
        int[] wordsCount = new int[differentWords.Count];

        for (int i = 0; i < allWords.Length; i++)
        {
            string currentWords = allWords[i];

            for (int j = 0; j < differentWords.Count; j++)
            {
                if (currentWords == differentWords[j])
                {
                    wordsCount[j]++;
                }
            }
        }

        for (int word = 0; word < wordsCount.Length; word++)
        {
            result.AppendFormat("{0} - {1}", differentWords[word], wordsCount[word]);
            result.AppendLine();
        }

        return result.ToString();
    }
}

//Write a program that reads a string from the
//console and lists all different words in the 
//string along with information how many times
//each word is found.