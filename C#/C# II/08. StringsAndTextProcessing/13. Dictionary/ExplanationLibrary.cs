using System;
using System.Collections.Generic;

public class ExplanationLibrary
{
    public Dictionary<string, string> dictionary = new Dictionary<string, string>();

    public ExplanationLibrary()
    {
        this.InitializeItem();
    }


    public void InitializeItem()
    {
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");
    }
}