using System;
using System.Collections.Generic;
using System.Text;
using SoftwareAcademy;

public abstract class Course : ICourse
{
    private string name;
    public ITeacher Teacher { get; set; }
    protected readonly List<string> allTopics;

    public Course(string name, ITeacher teacher)
    {
        this.Name = name;
        this.Teacher = teacher;
        this.allTopics = new List<string>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            this.name = value;
        }
    }

    public void AddTopic(string topic)
    {
        this.allTopics.Add(topic);
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

        output.Append(this.GetType().Name + ": ");
        output.Append("Name=" + this.Name);

        if (this.Teacher != null)
        {
            output.Append("; Teacher=" + this.Teacher.Name);
        }

        if (this.allTopics.Count != 0)
        {
            output.Append("; Topics=[");

            foreach (string topic in this.allTopics)
            {
                output.Append(topic + ", ");
            }

            output.Length -= 2;
            output.Append("]");
        }

        return output.ToString();
    }
}