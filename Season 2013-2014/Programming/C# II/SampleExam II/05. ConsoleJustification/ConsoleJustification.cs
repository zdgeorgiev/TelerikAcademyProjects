using System;
using System.Collections.Generic;
using System.Text;

class ConsoleJustification
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        List<string> words = new List<string>();

        for (int i = 0; i < rows; i++)
        {
            //Get every words and add it to the list
            words.AddRange(Console.ReadLine().Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        string[] allWords = words.ToArray();

        Console.WriteLine(JustifyTheText(allWords, width));
    }

    private static string JustifyTheText(string[] allWords, int width)
    {
        StringBuilder result = new StringBuilder();

        //TODO :

        return result.ToString();
    }
}