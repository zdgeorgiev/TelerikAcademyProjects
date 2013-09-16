using System;
using System.Text;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] allWords = new string[n];

        int bestLenght = 0;

        for (int i = 0; i < n; i++)
        {
            allWords[i] = Console.ReadLine();

            int currentLenght = allWords[i].Length;

            if (currentLenght > bestLenght)
            {
                bestLenght = currentLenght;
            }
        }

        var list = allWords.ToList<string>();

        for (int i = 0; i < n; i++)
        {
            string currentWord = list[i];
            int nextPosition = currentWord.Length % (n + 1);

            list.Insert(nextPosition, currentWord);

            if (nextPosition < i)
            {
                list.RemoveAt(i + 1);
            }
            else
            {
                list.RemoveAt(i);
            }
        }

        Print(list.ToArray(), bestLenght);
    }

    private static void Print(string[] allWords, int bestLenght)
    {
        int counter = 0;
        StringBuilder result = new StringBuilder();

        while (true)
        {
            for (int i = 0; i < allWords.Length; i++)
            {
                if (allWords[i].Length <= counter || allWords[i][counter] == '1' || allWords[i][counter] == ' ')
                {
                    continue;
                }

                result.Append(allWords[i][counter]);
            }

            counter++;

            if (counter == bestLenght)
            {
                break;
            }
        }

        Console.WriteLine(result.ToString());
    }
}