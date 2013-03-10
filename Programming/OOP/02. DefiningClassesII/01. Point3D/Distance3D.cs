namespace DefiningClassesPartII
{
    using System;

    public static class Distance3D
    {
        public static int CalculateDistance(Point3D first, Point3D second)
        {
            int distance = new int();
            distance = (first.X - second.X) * (first.Y - second.Y) * (first.Z - second.Z);
            return distance;
        }
    }
}