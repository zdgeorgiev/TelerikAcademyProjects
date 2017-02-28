using System;
using System.Collections.Generic;

public class WordDocument : OfficeDocument
{
    public string Chars { get; set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
        {
            this.Chars = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("chars", this.Chars));

        base.SaveAllProperties(output);
    }
}