using System;
using SoftwareAcademy;

public class OffsiteCourse : Course, IOffsiteCourse
{
    private string town;

    public OffsiteCourse(string name, ITeacher teacher, string town)
        : base(name, teacher)
    {
        this.Town = town;
    }

    public string Town
    {
        get { return this.town; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            this.town = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + "; Town=" + this.Town;
    }
}