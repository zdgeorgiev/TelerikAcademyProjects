using System;
using System.Collections.Generic;

public class People : ICommentable
{
    private string name;
    private readonly List<string> allComments;

    public People(string name)
    {
        this.Name = name;
        this.allComments = new List<string>();
    }

    public List<string> AllComments
    {
        get { return this.allComments; }
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid name");
            }

            this.name = value;
        }
    }

    public void AddComment(string comment)
    {
        this.allComments.Add(comment);
    }
}