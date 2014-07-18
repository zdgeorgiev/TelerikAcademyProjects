using System;

class InsideTheBuilding
{
    static int h;

    static void Main(string[] args)
    {
        h = int.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
		{
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(ItsInside(x, y));
        }
    }

    private static string ItsInside(int x, int y)
    {
        string isInside = "inside";

        if (x > h * 3 || x < 0)
        {
            isInside = "outside";
            return isInside;
        }
        else if (y > h * 4 || y < 0)
        {
            isInside = "outside";
            return isInside;
        }

        if (x < h || x > h * 2)
        {
            if (y > h || y < 0)
            {
                isInside = "outside";
                return isInside;
            }
        }
        else if (x >= h || x <= h * 2)
        {
            if (y > h * 4 || y < 0)
            {
                isInside = "outside";
                return isInside;
            }
        }

        return isInside;
    }
}