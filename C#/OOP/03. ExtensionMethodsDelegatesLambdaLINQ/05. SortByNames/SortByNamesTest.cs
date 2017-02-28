using System;
using System.Collections.Generic;
using System.Linq;

class SortByNamesTest
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

        var sortedLambda = students.OrderBy(student => student.FirstName)
            .ThenByDescending(student => student.LastName);

        foreach (Student student in sortedLambda)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("LINQ\n");

        var sortedLinq =
            from student in students
            orderby student.FirstName, student.LastName descending
            select student;

        foreach (Student student in sortedLinq)
        {
            Console.WriteLine(student);
        }
    }
}

//Using the extension methods OrderBy() and ThenBy() with lambda
//expressions sort the students by first name and last name 
//in descending order. Rewrite the same with LINQ.