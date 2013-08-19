using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    private static int width, height, depth;

    static void Main(string[] args)
    {
        string[] dimension = Console.ReadLine().Split();

        width = int.Parse(dimension[0]);
        height = int.Parse(dimension[1]);
        depth = int.Parse(dimension[2]);

        string[, ,] cube = new string[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] currentLineColors = Console.ReadLine().Split();

            for (int d = 0; d < currentLineColors.Length; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = currentLineColors[d][w].ToString();
                }
            }
        }

        string output = FindStars(cube);

        Console.WriteLine(output);
    }

    private static string FindStars(string[, ,] cube)
    {
        StringBuilder result = new StringBuilder();

        Dictionary<string, int> allPossibleStars = new Dictionary<string, int>()
        {
            {"A", 0},
            {"B", 0},
            {"C", 0},
            {"D", 0},
            {"E", 0},
            {"F", 0},
            {"G", 0},
            {"H", 0},
            {"I", 0},
            {"J", 0},
            {"K", 0},
            {"L", 0},
            {"M", 0},
            {"N", 0},
            {"O", 0},
            {"P", 0},
            {"Q", 0},
            {"R", 0},
            {"S", 0},
            {"T", 0},
            {"U", 0},
            {"V", 0},
            {"W", 0},
            {"X", 0},
            {"Y", 0},
            {"Z", 0}
        };

        int starsCounter = 0;

        for (int h = 1; h < height - 1; h++)
        {
            for (int w = 1; w < width - 1; w++)
            {
                for (int d = 1; d < depth - 1; d++)
                {
                    string currentColor = cube[w, h, d];

                    if (currentColor == cube[w + 1, h, d] &&
                        currentColor == cube[w - 1, h, d] &&
                        currentColor == cube[w, h + 1, d] &&
                        currentColor == cube[w, h - 1, d] &&
                        currentColor == cube[w, h, d + 1] &&
                        currentColor == cube[w, h, d - 1])
                    {
                        allPossibleStars[currentColor]++;

                        starsCounter++;
                    }
                }
            }
        }

        result.AppendLine(starsCounter.ToString());

        foreach (var color in allPossibleStars)
        {
            if (color.Value > 0)
            {
                result.AppendLine(color.Key + " " + color.Value);
            }
        }

        return result.ToString();
    }
}