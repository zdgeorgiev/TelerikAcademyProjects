namespace DefiningClassesPartII
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Point3D point = new Point3D(6, 3, 1);
            Console.WriteLine(point);
            Console.WriteLine(Point3D.Center);

            int distance = Distance3D.CalculateDistance(point, Point3D.Center);
            Console.WriteLine(distance);

            Point3D point1 = new Point3D();
            Path path = new Path();
            path.Add(point1);

            PathStorage.Save(path);
            List<Path> pathList = PathStorage.Load();

            foreach (var paths in pathList)
            {
                foreach (var pointPath in paths.Paths)
                {
                    Console.WriteLine(pointPath);
                }
            }
        }
    }
}
