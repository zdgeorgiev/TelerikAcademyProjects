using System;

class VersionAttributeTest
{
    static void Main()
    {
        Point point = new Point(5, 1);

        object[] allVersions = point.GetType().GetCustomAttributes(false);

        foreach (VersionAttribute version in allVersions)
        {
            Console.WriteLine(version);
        }
    }
}