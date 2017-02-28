using System;
using System.Collections.Generic;

public class Path
{
    public readonly List<Point3D> allPoints = new List<Point3D>();

    public Path()
    {
    }

    public Path(List<Point3D> allPoints)
    {
        this.allPoints = allPoints;
    }

    public void AddPoint(Point3D point)
    {
        this.allPoints.Add(point);
    }

    public void RemovePoint(Point3D point)
    {
        if (!this.allPoints.Contains(point))
        {
            throw new ArgumentException(string.Format
                ("This path doesnt contains Point with coords {0},{1},{2}", point.X, point.Y, point.Z));
        }

        this.allPoints.Remove(point);
    }

    public void ClearPath()
    {
        this.allPoints.Clear();
    }
}