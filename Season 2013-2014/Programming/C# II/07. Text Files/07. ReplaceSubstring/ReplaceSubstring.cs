using System;
using System.IO;
using System.Text;
using System.Linq;

class ReplaceSubstring
{
    public const string SearchedWord = "start";
    public const string ReplacedWord = "finish";

    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../input.txt");
        StringBuilder textFromTheFile = new StringBuilder();

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                textFromTheFile.AppendLine(line);
                line = reader.ReadLine();
            }

            for (int i = 0; i < textFromTheFile.Length - (SearchedWord.Length - 1); i++)
            {
                //if found the searched word
                if (textFromTheFile.ToString().Substring(i, SearchedWord.Length) == SearchedWord)
                {
                    textFromTheFile.Replace(SearchedWord, ReplacedWord, i, ReplacedWord.Length);
                }
            }
        }

        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            writer.WriteLine(textFromTheFile);
            Console.WriteLine("Finished.");
        }
    }
}

//Write a program that replaces all occurrences of the
//substring "start" with the substring "finish" in
//a text file. Ensure it will work with large files (e.g. 100 MB).