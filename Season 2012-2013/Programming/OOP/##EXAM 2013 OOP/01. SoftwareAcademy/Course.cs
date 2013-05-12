using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Course : ICourse
{
    private readonly List<string> topics;
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
    public ITeacher Teacher { get; set; }

    //constructor
    public Course(string name, ITeacher teacher)
    {
        this.Name = name;
        this.Teacher = teacher;
        this.topics = new List<string>();
    }

    public void AddTopic(string topic)
    {
        this.topics.Add(topic);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.Append(this.GetType().Name + ": Name=" + this.Name); //(course type): Name=(course name);

        if (this.Teacher != null)
        {
            result.Append("; Teacher=" + this.Teacher.Name); //Teacher=(teacher name);
        }

        if (topics.Count > 0)
        {
            result.Append("; Topics=[");

            foreach (var topic in topics)
            {
                result.Append(topic);
                result.Append(", ");
            }

            result.Length -= 2;
            result.Append("]"); //Topics=[(course topics – comma separated)];
        }

        return result.ToString();
    }
}