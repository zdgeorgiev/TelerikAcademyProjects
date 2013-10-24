using System;
using SoftwareAcademy;
using System.Collections.Generic;
using System.Text;

public class Teacher : ITeacher
{
    public string Name { get; set; }
    private readonly List<ICourse> allCourses;

    public Teacher(string name)
    {
        this.Name = name;
        this.allCourses = new List<ICourse>();
    }

    public void AddCourse(ICourse course)
    {
        this.allCourses.Add(course);
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

        output.Append(this.GetType().Name + ": " + "Name=" + this.Name);

        if (this.allCourses.Count != 0)
        {
            output.Append("; Courses=[");

            foreach (ICourse course in this.allCourses)
            {
                output.Append(course.Name + ", ");
            }

            output.Length -= 2;
            output.Append("]");
        }

        return output.ToString();
    }
}