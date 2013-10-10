using System;
using System.Collections.Generic;

public class Class
{
    private int uniqueNumber;
    private readonly List<Teacher> allTeachers;
    private readonly List<Student> allStudents;

    public Class(int uniqueNumber)
    {
        this.UniqueNumber = uniqueNumber;
        this.allTeachers = new List<Teacher>();
        this.allStudents = new List<Student>();
    }

    public void AddTeacher(Teacher teacher)
    {
        if (this.allTeachers.Contains(teacher))
        {
            throw new ArgumentException("This teacher is already added.");
        }

        this.allTeachers.Add(teacher);
    }

    public void RemoveTeacher(Teacher teacher)
    {
        if (!this.allTeachers.Contains(teacher))
        {
            throw new ArgumentException("Teacher not found.");
        }

        this.allTeachers.Remove(teacher);
    }

    public void AddStudent(Student student)
    {
        if (this.allStudents.Contains(student))
        {
            throw new ArgumentException("This student is already added.");
        }

        this.allStudents.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        if (!this.allStudents.Contains(student))
        {
            throw new ArgumentException("Student not found.");
        }

        this.allStudents.Remove(student);
    }

    public List<Teacher> AllTeachers
    {
        get { return this.allTeachers; }
    }

    public List<Student> AllStudents
    {
        get { return this.allStudents; }
    }

    public int UniqueNumber
    {
        get { return this.uniqueNumber; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid unique class number.");
            }

            this.uniqueNumber = value;
        }
    }
}