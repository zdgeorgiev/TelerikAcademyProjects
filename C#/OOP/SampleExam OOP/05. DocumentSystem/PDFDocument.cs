using System;
using System.Collections.Generic;

public class PDFDocument : TextDocument
{
    public int Pages { get; set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
        {
            this.Pages = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("pages", this.Pages));

        base.SaveAllProperties(output);
    }

    public bool IsEncrypted
    {
        get { throw new NotImplementedException(); }
    }

    public void Encrypt()
    {
        throw new NotImplementedException();
    }

    public void Decrypt()
    {
        throw new NotImplementedException();
    }
}