using System;
using System.Collections.Generic;

public class Course
{
    private string name;
    private const int MaxPeoplesPerCourse = 30;
    public readonly List<Student> AllRecordedStudents = new List<Student>();

    public Course(string name)
        : this(name, new List<Student>())
    {
    }

    public Course(string name, List<Student> students)
    {
        this.Name = name;
        this.AllRecordedStudents = students;
    }

    public void AddStudent(Student student)
    {
        bool isStudentAlreadyExist = this.AllRecordedStudents.Contains(student);

        if (isStudentAlreadyExist)
        {
            throw new ArgumentException("Student is already signed for this course.");
        }

        if (this.AllRecordedStudents.Count >= MaxPeoplesPerCourse)
        {
            throw new ArgumentException("Course reached his limit of 30 peoples.");
        }

        this.AllRecordedStudents.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        bool isStudentNotExist = !this.AllRecordedStudents.Contains(student);

        if (isStudentNotExist)
        {
            throw new ArgumentException("Student isnt signed for this course.");
        }

        this.AllRecordedStudents.Remove(student);
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Name is obligatory!");
            }

            this.name = value;
        }
    }
}