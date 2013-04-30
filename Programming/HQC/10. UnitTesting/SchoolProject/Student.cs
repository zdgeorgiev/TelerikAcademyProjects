using System;

public class Student
{
    private string name;
    private int uniqueNumber;

    public Student(string name, int uniqueNumber)
    {
        this.Name = name;
        this.UniqueNumber = uniqueNumber;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Name is obligatory!");
            }

            this.name = value;
        }
    }

    public int UniqueNumber
    {
        get { return this.uniqueNumber; }
        set 
        {
            if (10000 > value || value > 99999)
            {
                throw new IndexOutOfRangeException("Unique number should be in range [10000...99999]!");
            }

            this.uniqueNumber = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Student name - {0}, UniqueNumber - {1}", this.Name, this.UniqueNumber);
    }
}