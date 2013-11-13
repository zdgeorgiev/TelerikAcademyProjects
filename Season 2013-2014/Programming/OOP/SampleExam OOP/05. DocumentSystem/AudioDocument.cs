using System;
using System.Collections.Generic;

public class AudioDocument : MultimediaDocument
{
    public int FrameRate { get; set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
        {
            this.FrameRate = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));

        base.SaveAllProperties(output);
    }
}