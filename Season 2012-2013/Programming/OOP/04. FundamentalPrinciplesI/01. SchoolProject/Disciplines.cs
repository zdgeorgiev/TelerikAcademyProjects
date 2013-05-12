using System;
using System.Collections.Generic;

public class Disciplines : ICommentable
{
    public List<string> Comments { get; set; }
    public int NumberOfExercises { get; set; }
    public int NumberOfLectures { get; set; }
    public string Name { get; set; }

    public Disciplines(string name, int numberOfLectures = 0, int numberOfExercises = 0)
    {
        this.Comments = new List<string>();
    }

    public void AddComment(string text)
    {
        this.Comments.Add(text);
    }
}

//We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number.
//Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises.
//Both teachers and students are people. Students, classes, teachers and disciplines
//could have optional comments (free text block).