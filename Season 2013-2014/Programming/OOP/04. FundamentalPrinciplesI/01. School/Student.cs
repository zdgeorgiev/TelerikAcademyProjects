using System;

public class Student : People
{
    private int uniqueNumber;

    public Student(string name, int uniqueNumber)
        : base(name)
    {
        this.UniqueNumber = uniqueNumber;
    }

    public int UniqueNumber
    {
        get { return this.uniqueNumber; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Unique class number cannot be a negative number");
            }

            this.uniqueNumber = value;
        }
    }
}