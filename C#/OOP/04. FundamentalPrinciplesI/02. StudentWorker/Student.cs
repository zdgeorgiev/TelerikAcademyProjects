﻿using System;

public class Student : Human
{
    private int grade;

    public Student(string firstName, string lastName, int grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }

    public int Grade
    {
        get { return this.grade; }
        set
        {
            if (value <= 0 || value > 12)
            {
                throw new ArgumentException("Invalid grade");
            }

            this.grade = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + ", Grade - " + this.Grade;
    }
}