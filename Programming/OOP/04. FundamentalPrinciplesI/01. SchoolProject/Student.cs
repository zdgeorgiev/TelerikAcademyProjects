using System;
using System.Collections.Generic;
using System.Text;

public class Student : Person, ICommentable
{
    public int UniqueNumber { get; set; }
    public List<string> Comments { get; set; }

    public Student(string firstName, string secondName, string lastName, int uniqueNumber)
        : base(firstName, secondName, lastName)
    {
        this.UniqueNumber = uniqueNumber;
        this.Comments = new List<string>();
    }

    public void AddComment(string text)
    {
        this.Comments.Add(text);
    }

    //public override string ToString()
    //{
    //    StringBuilder stBuilder = new StringBuilder();
    //    stBuilder.AppendLine(string.Format("NAME - {0} {1} {2}",this.FirstName, this.SecondName, this.LastName));
    //    stBuilder.Append(string.Format("UNIQUE NUMBER - {0}", this.UniqueNumber));
    //    return stBuilder.ToString();
    //}
}
