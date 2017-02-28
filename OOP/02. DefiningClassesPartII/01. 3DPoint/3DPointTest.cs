using System;
using System.IO;

class Point3DTest
{
    public static void Main()
    {
        Path firstPath = PathStorage.LoadPath(new StreamReader("../../Path01.txt"));
        Path secondPath = PathStorage.LoadPath(new StreamReader("../../Path02.txt"));

        for (int i = 0; i < firstPath.allPoints.Count; i++)
        {
            Console.WriteLine(DistanceCalculator.CalcDistanceBetweenPoints(
                firstPath.allPoints[i], secondPath.allPoints[i]));
        }
    }
}