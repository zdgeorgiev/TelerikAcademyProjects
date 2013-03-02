namespace DefiningClassesPartII
{
    using System;

    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        private static readonly Point3D center = new Point3D(0, 0, 0);

        //Methods
        public override string ToString()
        {
            return string.Format("Point is with coordinates {0},{1},{2}", X, Y, Z);
        }

        //Constructors
        public Point3D(int x, int y, int z) : this() //struct need empty constructor when use automatic properties.
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //Properties
        public static Point3D Center
        {
            get { return center; }
        }
    }
}

