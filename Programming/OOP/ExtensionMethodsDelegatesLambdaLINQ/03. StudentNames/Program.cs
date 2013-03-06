using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student {Name = "Petar", SecondName = "Kolev"},
            new Student {Name = "Stefan", SecondName = "Dobrev"},
            new Student {Name = "Georgi", SecondName = "Angelov"},
            new Student {Name = "Zdravko", SecondName = "Stefanov"},
            new Student {Name = "Angel", SecondName = "Jekov"},
            new Student {Name = "Yavor", SecondName = "Zdravkov"}
        };
        var sordetByName = students.FindAll(x => x.Name.CompareTo(x.SecondName) == -1);

        foreach (var item in sordetByName)
        {
            Console.WriteLine("{0} {1}", item.Name, item.SecondName);
        }

        Console.WriteLine("--------------");

        var sortedStudentsLINQ =
            from student in students
            where student.Name.CompareTo(student.SecondName) == -1
            select student;

        foreach (var item in sortedStudentsLINQ)
        {
            Console.WriteLine("{0} {1}", item.Name, item.SecondName);
        }
    }
}

//Write a method that from a given array of students finds all students whose 
//first name is before its last name alphabetically.
//Use LINQ query operators.
