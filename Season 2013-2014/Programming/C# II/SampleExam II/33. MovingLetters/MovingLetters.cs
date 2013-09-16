using System;
using System.Text;

class MovingLetters
{
    static void Main(string[] args)
    {
        string[] inputWords = Console.ReadLine().Split();

        int bestLenght = 0;

        for (int i = 0; i < inputWords.Length; i++)
        {
            int currentLenght = inputWords[i].Length;

            string reversed = string.Empty;

            for (int j = 0; j < inputWords[i].Length; j++)
            {
                reversed += inputWords[i][inputWords[i].Length - 1 - j];
            }

            if (currentLenght > bestLenght)
            {
                bestLenght = currentLenght;
            }

            inputWords[i] = reversed;
        }

        int counter = 0;
        StringBuilder result = new StringBuilder();

        while (true)
        {
            for (int i = 0; i < inputWords.Length; i++)
            {
                if (counter < inputWords[i].Length && inputWords[i][counter] != ' ')
                {
                    result.Append(inputWords[i][counter]);
                }
            }

            counter++;

            if (counter == bestLenght)
            {
                break;
            }
        }

        for (int i = 0; i < result.Length; i++)
        {
            string currentChar = result[i].ToString().ToLower();

            int moves = ((int)(char.Parse(currentChar)) - 96);
            int nextIndex = (moves + i) % result.Length;

            if (nextIndex < i)
            {
                result.Insert(nextIndex, result[i]);
                result.Remove(i + 1, 1);
            }
            else
            {
                result.Insert(nextIndex + 1, result[i]);
                result.Remove(i, 1);
            }
        }

        Console.WriteLine(result.ToString());
    }
}