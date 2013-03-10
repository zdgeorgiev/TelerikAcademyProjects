﻿using System;
using System.Collections.Generic;
using System.Text;

public class Teacher : Person, ICommentable
{
    public List<Disciplines> SetOfDisctiplines { get; set; }
    public List<string> Comments { get; set; }

    public global::Disciplines Disciplines
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }

    public Teacher(string firstName, string secondName, string lastName)
        : base(firstName, secondName, lastName)
    {
        this.SetOfDisctiplines = new List<Disciplines>();
        this.Comments = new List<string>();
    }

    public void AddComment(string text)
    {
        this.Comments.Add(text);
    }

    public void AddDiscripline(Disciplines discipline)
    {
        this.SetOfDisctiplines.Add(discipline);
    }

    public void RemoveDiscipline(Disciplines discipline)
    {
        this.SetOfDisctiplines.Remove(discipline);
    }
}

//We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number.
//Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises.
//Both teachers and students are people. Students, classes, teachers and disciplines
//could have optional comments (free text block).
//Your task is to identify the classes (in terms of  OOP) and their
//attributes and operations, encapsulate their fields, define the class
// hierarchy and create a class diagram with Visual Studio.
