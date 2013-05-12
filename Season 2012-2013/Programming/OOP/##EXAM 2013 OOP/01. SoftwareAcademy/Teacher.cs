using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Teacher : ITeacher
{
    private readonly List<ICourse> courses;
    private string name;

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            this.name = value;
        }
    }

    public Teacher(string name)
    {
        this.Name = name;
        this.courses =  new List<ICourse>();
    }

    public void AddCourse(ICourse course)
    {
        this.courses.Add(course);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.Append(this.GetType().Name + ": Name=" + this.Name);

        if (courses.Count > 0)
        {
            result.Append("; Courses=[");

            foreach (var course in courses)
            {
                result.Append(course.Name);
                result.Append(", ");
            }

            result.Length -= 2;
            result.Append("]");
        }

        return result.ToString();
    }
}
