using System;
using System.IO;
using System.Text;

class DeletePrefix
{
    public const string PrefixValue = "test";

    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../input.txt");

        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] allWords = line.Split(' ', ',', '.');

                    writer.WriteLine(RemoveThePrefix(PrefixValue, allWords));

                    line = reader.ReadLine();
                }

                Console.WriteLine("Finished.");
            }
        }
    }

    static string RemoveThePrefix(string prefix, string[] allWords)
    {
        StringBuilder convertedWords = new StringBuilder();

        for (int currentWord = 0; currentWord < allWords.Length; currentWord++)
        {
            if (allWords[currentWord].Length <= prefix.Length)
            {
                convertedWords.Append(allWords[currentWord] + " ");
            }
            else
            {
                bool isPrefixFound = allWords[currentWord].Substring(0, prefix.Length) == prefix;

                if (isPrefixFound)
                {
                    string newWord = string.Empty;

                    //Get the rest of the word beggin from the next index after the prefix
                    for (int j = prefix.Length; j < allWords[currentWord].Length; j++)
                    {
                        newWord += allWords[currentWord][j];
                    }

                    convertedWords.Append(newWord + " ");
                }
            }
        }

        //Remove the last whitespace
        convertedWords.Length--;

        return convertedWords.ToString();
    }
}

//Write a program that deletes from a text file all words 
//that start with the prefix "test". Words contain only 
//the symbols 0...9, a...z, A…Z, _.