using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Petar", SecondName = "Kolev", Age = 20 },
            new Student { Name = "Stefan", SecondName = "Dobrev", Age = 21 },
            new Student { Name = "Georgi", SecondName = "Angelov", Age = 17 },
            new Student { Name = "Zdravko", SecondName = "Stefanov", Age = 25 },
            new Student { Name = "Angel", SecondName = "Jekov", Age = 22 },
            new Student { Name = "Yavor", SecondName = "Zdravkov", Age = 24 }
        };

        var sortedStudentss = students.FindAll(x => x.Age <= 24 && x.Age >= 18);
        foreach (var student in sortedStudentss)
        {
            Console.WriteLine("{0} {1} {2}", student.Name, student.SecondName, student.Age);
        }

        Console.WriteLine("-----------------");

        var sortedStudents =
            from student in students
            where student.Age <= 24 && student.Age >= 18
            select student;

        foreach (var student in sortedStudents)
        {
            Console.WriteLine("{0} {1} {2}", student.Name, student.SecondName, student.Age);
        }
    }
}

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
