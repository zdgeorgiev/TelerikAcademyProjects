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
<<<<<<< HEAD
<<<<<<< HEAD

=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
        while (true)
        {
            cube[nextWidth, nextHeight, nextDepth] = -1;
            int count = 0;
<<<<<<< HEAD
<<<<<<< HEAD

=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
            if (nextWidth + laserDirWidth < 1 || nextWidth + laserDirWidth > width)
            {
                ChangeTheDirection(ref laserDirWidth);
                count++;
            }
<<<<<<< HEAD
<<<<<<< HEAD

=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
            if (nextHeight + laserDirHeight < 1 || nextHeight + laserDirHeight > height)
            {
                ChangeTheDirection(ref laserDirHeight);
                count++;
            }
<<<<<<< HEAD
<<<<<<< HEAD

=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
            if (nextDepth + laserDirDepth < 1 || nextDepth + laserDirDepth > depth)
            {
                ChangeTheDirection(ref laserDirDepth);
                count++;
            }
 
            nextWidth += laserDirWidth;
            nextHeight += laserDirHeight;
            nextDepth += laserDirDepth;
<<<<<<< HEAD
<<<<<<< HEAD

=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
=======
 
>>>>>>> cdd8653caf76bfa1b23bb523e03f1c174d99b1e4
            if (cube[nextWidth, nextHeight, nextDepth] == -1 || count == 3)
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
