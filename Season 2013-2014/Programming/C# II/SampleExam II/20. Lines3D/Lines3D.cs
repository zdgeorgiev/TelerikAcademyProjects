using System;

class Lines3D
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

        int bestLineLenght = 0;
        int bestLineCounter = 0;

        Console.WriteLine(bestLineLenght + " " + bestLineCounter);
    }
}