using System;
using System.IO;

class RemoveListedWords
{
    static void Main(string[] args)
    {
        StreamReader textReader = new StreamReader("../../input.txt");
        StreamReader forbiddenWords = new StreamReader("../../forbiddenWords.txt");

        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            string line = textReader.ReadLine();
            string[] allForbiddenWords = forbiddenWords.ReadLine().Split(',');

            while (line != null)
            {
                for (int word = 0; word < allForbiddenWords.Length; word++)
                {
                    if (line.Contains(allForbiddenWords[word].Trim()))
                    {
                        line = line.Replace(allForbiddenWords[word], string.Empty);
                    }
                }

                writer.WriteLine(line);
                line = textReader.ReadLine();
            }

            Console.WriteLine("Finished.");
        }
    }
}


//Write a program that removes from a text file all
//words listed in given another text file. Handle
//all possible exceptions in your methods.