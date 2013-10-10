using System;
using System.Collections.Generic;

public class Discipline : ICommentable
{
    private string name;
    private int numberOfLectures;
    private int numberOfExercises;
    private List<string> allComments;

    public Discipline(string name, int numberOfLectures, int numberOfExercises)
    {
        this.Name = name;
        this.numberOfLectures = numberOfLectures;
        this.numberOfExercises = numberOfExercises;
        this.allComments = new List<string>();
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

    public int NumberOfLectures
    {
        get { return this.numberOfLectures; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Number of lectures cannot be less than 1");
            }

            this.numberOfLectures = value;
        }
    }

    public int NumberOfexercises
    {
        get { return this.numberOfExercises; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Number of exercises cannot be less than 1");
            }

            this.numberOfExercises = value;
        }
    }

    public void AddComment(string comment)
    {
        this.allComments.Add(comment);
    }
}