using System;

public class Student : Human
{
    public int Grade { get; set; }

    public Student(string firstName, string lastName, int grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2}", base.FirstName, base.LastName, this.Grade);
    }
}