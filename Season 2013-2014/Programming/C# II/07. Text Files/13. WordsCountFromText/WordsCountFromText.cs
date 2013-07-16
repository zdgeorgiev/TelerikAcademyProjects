using System;
using System.IO;
using System.Text;

class WordsCountFromText
{
    static void Main(string[] args)
    {
        StreamReader textReader = new StreamReader("../../input.txt");
        StreamReader searchedWordsReader = new StreamReader("../../searchedWords.txt");

        string words = string.Empty;

        using (searchedWordsReader)
        {
            words = searchedWordsReader.ReadToEnd();
        }

        string[] allSearchedWords = words.Split(',', ' ');
        //Sort the words in descending order
        Array.Sort(allSearchedWords);
        int[] searchedWordsCounter = new int[allSearchedWords.Length];

        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            StringBuilder result = new StringBuilder();
            string line = textReader.ReadLine();

            while (line != null)
            {
                string[] allWordsFromTheLine = line.Split(' ');

                for (int searchedWord = 0; searchedWord < searchedWordsCounter.Length; searchedWord++)
                {
                    for (int currentWord = 0; currentWord < allWordsFromTheLine.Length; currentWord++)
                    {
                        if (allWordsFromTheLine[currentWord].Trim() == allSearchedWords[searchedWord].Trim())
                        {
                            searchedWordsCounter[searchedWord]++;
                        }
                    }

                    result.AppendFormat("{0} - {1} times", allSearchedWords[searchedWord].Trim(),
                        searchedWordsCounter[searchedWord]);
                    result.AppendLine();
                }

                line = textReader.ReadLine();
            }

            writer.WriteLine(result);
            Console.WriteLine("Finished.");
        }
    }
}

//Write a program that reads a list of words from a file
//words.txt and finds how many times each of the words is
//contained in another file test.txt. The result should 
//be written in the file result.txt and the words should
//be sorted by the number of their occurrences in descending
//order. Handle all possible exceptions in your methods.