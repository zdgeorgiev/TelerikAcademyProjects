using System;
using System.Text;

public class Person
{
    public string Name { get; set; }
    public int? Age { get; set; }

    public Person(string name, int? age = null)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

        if (!string.IsNullOrEmpty(this.Name))
        {
            output.AppendFormat("Name - {0}", this.Name);
            output.AppendLine();
        }

        if (this.Age != null)
        {
            output.AppendFormat("Age - {0}", this.Age);
        }
        else
        {
            output.Append("Age - Not specified.");
        }

        return output.ToString();
    }
}