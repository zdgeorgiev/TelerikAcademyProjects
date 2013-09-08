using System;

class Laser
{
    private static int width, height, depth;
    private static int laserWidth, laserHeight, laserDepth;

    static void Main(string[] args)
    {
        string[] cubeDimentions = Console.ReadLine().Split();

        width = int.Parse(cubeDimentions[0]);
        height = int.Parse(cubeDimentions[1]);
        depth = int.Parse(cubeDimentions[2]);

        int[, ,] cube = new int[width + 1, height + 1, depth + 1];

        string[] laserCoords = Console.ReadLine().Split();

        laserWidth = int.Parse(laserCoords[0]);
        laserHeight = int.Parse(laserCoords[1]);
        laserDepth = int.Parse(laserCoords[2]);

        string[] laserDirection = Console.ReadLine().Split();

        int laserDirWidth = int.Parse(laserDirection[0]);
        int laserDirHeight = int.Parse(laserDirection[1]);
        int laserDirDepth = int.Parse(laserDirection[2]);

        int nextWidth = laserWidth;
        int nextHeight = laserHeight;
        int nextDepth = laserDepth;

        cube[1, 1, 1] = -1;
        cube[width, height, depth] = -1;
        cube[1, height, 1] = -1;
        cube[width, 1, 1] = -1;
        cube[1, 1, depth] = -1;
        cube[width, height, 1] = -1;
        cube[width, 1, depth] = -1;
        cube[1, height, depth] = -1;

        while (true)
        {
            cube[laserWidth, laserHeight, laserDepth] = -1;

            if (nextWidth + laserDirWidth > 1 || nextWidth + laserDirWidth > width)
            {
                ChangeTheDirection(ref laserDirWidth);
            }

            if (nextHeight + laserDirHeight > 1 || nextHeight + laserDirHeight > height)
            {
                ChangeTheDirection(ref laserDirHeight);
            }

            if (nextDepth + laserDirDepth > 1 || nextDepth + laserDirDepth > depth)
            {
                ChangeTheDirection(ref laserDirDepth);
            }

            nextWidth += laserDirWidth;
            nextHeight += laserDirHeight;
            nextDepth += laserDirDepth;

            if (cube[nextWidth, nextHeight, nextDepth] == -1)
            {
                Console.WriteLine("{0} {1} {2}",
                    nextWidth - laserDirWidth, nextHeight - laserDirHeight, nextDepth - laserDirDepth);
                break;
            }
        }
    }

    private static void ChangeTheDirection(ref int direction)
    {
        if (direction == 1)
        {
            direction = -1;
        }
        else if (direction == -1)
        {
            direction = 1;
        }
    }
}