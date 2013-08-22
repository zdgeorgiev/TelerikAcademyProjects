using System;

class MaxWalk3D
{
    private static int width, height, depth;

    static void Main(string[] args)
    {
        string[] rawDimentions = Console.ReadLine().Split();

        width = int.Parse(rawDimentions[0]);
        height = int.Parse(rawDimentions[1]);
        depth = int.Parse(rawDimentions[2]);

        int[, ,] cube = new int[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] currentLineNumbers =
                Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            for (int d = 0; d < depth; d++)
            {
                string[] currentNumbers =
                    currentLineNumbers[d].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = int.Parse(currentNumbers[w]);
                }
            }
        }

        bool[, ,] visited = new bool[width, height, depth];

        int currentWidth = width / 2;
        int currentHeight = height / 2;
        int currentDepth = depth / 2;

        int currentNumber = cube[currentWidth, currentHeight, currentDepth];

        int maxResult = currentNumber;

        while (true)
        {
            visited[currentWidth, currentHeight, currentDepth] = true;
            int bestValue = 0;
            int currentValue = 0;

            int bestValueWidth = currentWidth;
            int bestValueHeight = currentHeight;
            int bestValueDepth = currentDepth;

            for (int w = 0; w < width; w++)
            {
                if (w == currentWidth)
                {
                    continue;
                }

                currentValue = cube[w, currentHeight, currentDepth];

                if (bestValue <= currentValue)
                {
                    bestValue = currentValue;

                    bestValueWidth = w;
                    bestValueHeight = currentHeight;
                    bestValueDepth = currentDepth;
                }
            }

            for (int h = 0; h < height; h++)
            {
                if (h == currentHeight)
                {
                    continue;
                }

                currentValue = cube[currentWidth, h, currentDepth];

                if (bestValue < currentValue)
                {
                    bestValue = currentValue;

                    bestValueWidth = currentWidth;
                    bestValueHeight = h;
                    bestValueDepth = currentDepth;
                }
            }

            for (int d = 0; d < depth; d++)
            {
                if (d == currentDepth)
                {
                    continue;
                }

                currentValue = cube[currentWidth, currentHeight, d];

                if (bestValue < currentValue)
                {
                    bestValue = currentValue;

                    bestValueWidth = currentWidth;
                    bestValueHeight = currentHeight;
                    bestValueDepth = d;
                }
            }

            if (visited[bestValueWidth, bestValueHeight, bestValueDepth])
            {
                break;
            }

            currentWidth = bestValueWidth;
            currentHeight = bestValueHeight;
            currentDepth = bestValueDepth;

            maxResult += bestValue;
            currentValue = bestValue;
        }

        Console.WriteLine(maxResult);
    }
}