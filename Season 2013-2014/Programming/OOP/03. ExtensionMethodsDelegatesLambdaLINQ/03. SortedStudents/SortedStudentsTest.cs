using System;
using System.Collections.Generic;
using System.Linq;

class SortedStudentsTest
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student("Pesho","Sokratov"),
            new Student("Rumen","Ognqnov"),
            new Student("Staicho","Stefanov"),
            new Student("Bojidar","Kolev"),
            new Student("Dimitur","Balabanov"),
            new Student("Rumen","Prodanov"),
        };

        Console.WriteLine("LINQ\n");

        var sortedLambda = students.FindAll(student => student.FirstName.CompareTo(student.LastName) == -1);

        foreach (Student student in sortedLambda)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("LAMBDA\n");

        var sortedLinq =
            from student in students
            where student.FirstName.CompareTo(student.LastName) == -1
            select student;

        foreach (Student student in sortedLinq)
        {
            Console.WriteLine(student);
        }
    }
}

//Write a method that from a given array of students finds all students
//whose first name is before its last name alphabetically. Use LINQ query operators.