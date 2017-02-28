using System;

public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    private static readonly Point3D zero = new Point3D(0, 0, 0);

    public static Point3D Zero
    {
        get { return Point3D.zero; }
    }

    public Point3D(int x, int y, int z) : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public override string ToString()
    {
        return string.Format("({0},{1},{2})", this.X, this.Y, this.Z);
    }
}