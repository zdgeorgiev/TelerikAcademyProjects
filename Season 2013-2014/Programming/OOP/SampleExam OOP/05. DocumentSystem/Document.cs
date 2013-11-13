using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public abstract class Document : IDocument
{
    public string Name { get; protected set; }
    public string Content { get; protected set; }

    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
        {
            this.Name = value;
        }
        else if (key == "content")
        {
            this.Content = value;
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>
            ("name", this.Name));

        output.Add(new KeyValuePair<string, object>
            ("content", this.Content));
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        IList<KeyValuePair<string, object>> allProperties = new List<KeyValuePair<string, object>>();
        this.SaveAllProperties(allProperties);

        var sorted = allProperties.OrderBy(item => item.Key);

        result.Append(this.GetType().Name);

        result.Append("[");

        foreach (var attr in sorted)
        {
            if (attr.Value != null)
            {
                result.Append(attr.Key + "=" + attr.Value + ";");
            }
        }

        result.Length--;
        result.Append("]");

        return result.ToString();
    }
}