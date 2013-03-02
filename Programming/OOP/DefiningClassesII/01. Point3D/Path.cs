namespace DefiningClassesPartII
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Path
    {
        public readonly List<Point3D> allPoints = new List<Point3D>();

        public List<Point3D> Paths
        {
            get { return this.allPoints; }
        }

        public void Add(Point3D newPoint)
        {
            allPoints.Add(newPoint);
        }

        public void ClearPoints()
        {
            allPoints.Clear();
        }
    }
}