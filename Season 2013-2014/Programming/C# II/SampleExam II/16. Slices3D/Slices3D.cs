using System;

class Slices3D
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
                Console.ReadLine().Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries);

            for (int d = 0; d < depth; d++)
            {
                string[] currentNumbers = 
                    currentLineNumbers[d].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = int.Parse(currentNumbers[w]);
                }
            }
        }

        long totalSum = 0;

        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    totalSum += cube[w, h, d];
                }
            }
        }

        int count = 0;
        long currentSum = 0;

        for (int w = 0; w < width - 1; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    currentSum += cube[w, h, d];
                }
            }

            if (currentSum * 2 == totalSum)
            {
                count++;
            }
        }

        currentSum = 0;

        for (int h = 0; h < height - 1; h++)
        {
            for (int w = 0; w < width; w++)
            {
                for (int d = 0; d < depth; d++)
                {
                    currentSum += cube[w, h, d];
                }
            }

            if (currentSum * 2 == totalSum)
            {
                count++;
            }
        }

        currentSum = 0;

        for (int d = 0; d < depth - 1; d++)
        {
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    currentSum += cube[w, h, d];
                }
            }

            if (currentSum * 2 == totalSum)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}