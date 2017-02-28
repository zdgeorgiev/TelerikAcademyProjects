using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class CourseTest
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CheckEmptyStringName()
    {
        Course course = new Course(string.Empty, new List<Student>());
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CheckNullName()
    {
        Course course = new Course(null, new List<Student>());
    }

    [TestMethod]
    public void CheckCourseName()
    {
        Course course = new Course("OOP", new List<Student>());
        Assert.AreEqual(course.Name, "OOP");
    }

    [TestMethod]
    public void CheckCourseDifferentName()
    {
        Course course = new Course("OOP", new List<Student>());
        Assert.AreNotEqual(course.Name, "TEST");
    }

    [TestMethod]
    public void AddStudent()
    {
        Student st = new Student("Pesho", 22222);
        Course course = new Course("OOP", new List<Student>());
        course.AddStudent(st);
        Assert.AreEqual(course.AllRecordedStudents.Count, 1);
    }

    [TestMethod]
    public void RemoveStudent()
    {
        Student st = new Student("Pesho", 22222);
        Course course = new Course("OOP", new List<Student>());
        course.AddStudent(st);
        course.RemoveStudent(st);
        Assert.AreEqual(course.AllRecordedStudents.Count, 0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddAlreadyExistingStudent()
    {
        Student st = new Student("Pesho", 22222);
        Course course = new Course("OOP", new List<Student> { st });
        course.AddStudent(st);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void RemoveNotExistingStudent()
    {
        Student st = new Student("Pesho", 22222);
        Course course = new Course("OOP", new List<Student> { st });
        Student st1 = new Student("Kolio", 21334);
        course.RemoveStudent(st1);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddMoreThanCourseLimitForStudents()
    {
        Course course = new Course("OOP", new List<Student>()
        {
            new Student("Peshoo", 20000),
            new Student("Stefan", 10001),
            new Student("Kolio", 14246),
            new Student("Peshoo", 20000),
            new Student("Stefan", 10001),
            new Student("Kolio", 14246),
            new Student("Peshoo", 20000),
            new Student("Stefan", 10001),
            new Student("Kolio", 14246),
            new Student("Peshoo", 20000),
            new Student("Stefan", 10001),
            new Student("Kolio", 14246),
            new Student("Peshoo", 20000),
            new Student("Stefan", 10001),
            new Student("Kolio", 14246),
            new Student("Peshoo", 20000),
            new Student("Stefan", 10001),
            new Student("Kolio", 14246),
            new Student("Peshoo", 20000),
            new Student("Stefan", 10001),
            new Student("Kolio", 14246),
            new Student("Peshoo", 20000),
            new Student("Stefan", 10001),
            new Student("Kolio", 14246),
            new Student("Peshoo", 20000),
            new Student("Peshoo", 20000),
            new Student("Stefan", 10001),
            new Student("Kolio", 14246),
            new Student("Peshoo", 20000),
            new Student("Peshoo", 20000),
        });

        course.AddStudent(new Student("Pesho", 34543));
    }

    [TestMethod]
    public void CheckNullStudentListConstructor()
    {
        Course course = new Course("OOP");
        Assert.AreEqual(course.AllRecordedStudents.Count, 0);
    }
}
