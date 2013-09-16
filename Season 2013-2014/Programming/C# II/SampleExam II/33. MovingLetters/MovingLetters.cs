using System;
using System.Text;

class MovingLetters
{
    static void Main(string[] args)
    {
        string[] inputWords = Console.ReadLine().Split();
        StringBuilder result = new StringBuilder();

        int counter = 0;

        while (true)
        {
            for (int i = 0; i < inputWords.Length; i++)
            {
                if (inputWords[i] != string.Empty)
                {
                    result.Append(inputWords[i][inputWords[i].Length - 1]);
                    inputWords[i] = inputWords[i].Substring(0, inputWords[i].Length - 1);
                }
                else
                {
                    counter++;
                }
            }

            if (counter == inputWords.Length)
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