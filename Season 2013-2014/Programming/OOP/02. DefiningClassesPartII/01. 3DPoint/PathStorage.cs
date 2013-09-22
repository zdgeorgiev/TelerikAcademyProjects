using System;
using System.IO;

public static class PathStorage
{
    public static Path LoadPath(StreamReader reader)
    {
        Path currentPath = new Path();

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] rawNumbers = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                int pointX = int.Parse(rawNumbers[0]);
                int pointY = int.Parse(rawNumbers[1]);
                int pointZ = int.Parse(rawNumbers[2]);

                currentPath.AddPoint(new Point3D(pointX, pointY, pointZ));

                line = reader.ReadLine();
            }
        }

        return currentPath;
    }

    public static void SavePath(Path currentPath, StreamWriter writer)
    {
        using (writer)
        {
            foreach (Point3D point in currentPath.allPoints)
            {
                writer.WriteLine(point.ToString());
            }
        }
    }
}