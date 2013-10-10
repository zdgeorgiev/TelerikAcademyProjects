using System;
using System.Collections.Generic;
using System.Linq;

class AgeOfStudentsTest
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student("Pesho","Sokratov", 18),
            new Student("Rumen","Ognqnov", 62),
            new Student("Staicho","Stefanov",26),
            new Student("Bojidar","Kolev",24),
            new Student("Dimitur","Balabanov", 22),
            new Student("Rumen","Prodanov", 14)
        };

        Console.WriteLine("LAMBDA\n");

        var sortedLambda = students.FindAll(student => student.Age >= 18 && student.Age <= 24);

        foreach (Student student in sortedLambda)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("LINQ\n");

        var sortedLinq =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;

        foreach (Student student in sortedLinq)
        {
            Console.WriteLine(student);
        }
    }
}

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.