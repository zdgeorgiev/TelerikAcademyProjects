namespace DefiningClassesPartII
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class PathStorage
    {
        public static void Save(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\PathSave.txt"))
            {
                foreach (Point3D point in path.Paths)
                {
                    Console.WriteLine(point);
                }
            }
        }

        public static List<Path> Load()
        {
            Path pointsPath = new Path();
            List<Path> allPaths = new List<Path>();

            using (StreamReader reader = new StreamReader(@"..\..\PathLoad.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (line != "-")
                    {
                        Point3D point = new Point3D();
                        string[] arrayPoints = line.Split(',');
                        point.X = int.Parse(arrayPoints[0]);
                        point.Y = int.Parse(arrayPoints[1]);
                        point.Z = int.Parse(arrayPoints[2]);
                        pointsPath.Add(point);
                    }
                    else
                    {
                        allPaths.Add(pointsPath);
                        pointsPath = new Path();
                    }
                    line = reader.ReadLine();
                }
                return allPaths;
            }
        }
    }
}

//Create a static class PathStorage with static methods
//    to save and load paths from a text file. Use a file format of your choice.
