using System;
using System.IO;
using System.Text;

class ReplaceWordsFromText
{
    public const string SearchedWord = "start";
    public const string ReplacedWord = "finish";

    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../input.txt");

        StringBuilder replacedText = new StringBuilder();
        string line = reader.ReadLine();

        while (line != null)
        {
            string[] allWords = line.ToString().Split(' ', '\n', '\r', '.', ',');

            for (int i = 0; i < allWords.Length; i++)
            {
                if (allWords[i] == SearchedWord)
                {
                    allWords[i] = ReplacedWord;
                }
            }

            replacedText.AppendLine(string.Join(" ", allWords));
            line = reader.ReadLine();
        }

        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            writer.WriteLine(replacedText);
            Console.WriteLine("Finished.");
        }
    }
}

//Modify the solution of the previous problem
//to replace only whole words (not substrings).