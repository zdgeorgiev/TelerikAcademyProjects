using System;
using System.Collections.Generic;

public class Class : ICommentable
{
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    public List<string> Comments { get; set; }
    public int Id { get; set; }

    public global::Student Student
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }

    public global::Teacher Teacher
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }

    public Class(List<Student> students, List<Teacher> teachers, int id)
    {
        this.Students = students;
        this.Teachers = teachers;
        this.Id = id;
        this.Comments = new List<string>();
    }

    public void AddComment(string text)
    {
        this.Comments.Add(text);
    }

    public void AddStudent(Student student)
    {
        this.Students.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        this.Students.Remove(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        this.Teachers.Add(teacher);
    }

    public void RemoveTeacher(Teacher teacher)
    {
        this.Teachers.Remove(teacher);
    }
}
