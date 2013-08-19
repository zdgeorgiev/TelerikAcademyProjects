using System;
using System.Collections.Generic;

class BombingCuboids
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
            string[] currentLine = Console.ReadLine().Split();

            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = currentLine[d][w];
                }
            }
        }

        int numbersOfBombs = int.Parse(Console.ReadLine());
        List<Bomb> allBombs = new List<Bomb>();

        for (int i = 0; i < numbersOfBombs; i++)
        {
            string[] rawNumbers = Console.ReadLine().Split();

            int bombWidth = int.Parse(rawNumbers[0]);
            int bombHeight = int.Parse(rawNumbers[1]);
            int bombDepth = int.Parse(rawNumbers[2]);
            int bombPower = int.Parse(rawNumbers[3]);

            allBombs.Add(new Bomb(bombWidth, bombHeight, bombDepth, bombPower));
        }

    }
}

//4 3 5
//AAAA AAAA AAAA AAAA AAAA
//AAAA AAAA AAAA AAAA AAAC
//ABAA AAAA AAAA AAAA AAAA
//3
//1 2 3 1
//0 0 0 2
//0 0 0 2