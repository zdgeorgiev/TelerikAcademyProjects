using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Student[] students = new Student[]
        {
            new Student { Name = "Petar", SecondName = "Kolev", Age = 20 },
            new Student { Name = "Stefan", SecondName = "Dobrev", Age = 21 },
            new Student { Name = "Georgi", SecondName = "Hristov", Age = 17 },
            new Student { Name = "Georgi", SecondName = "Angelov", Age = 13 },
            new Student { Name = "Zdravko", SecondName = "Stefanov", Age = 25 },
            new Student { Name = "Angel", SecondName = "Jekov", Age = 22 },
            new Student { Name = "Yavor", SecondName = "Zdravkov", Age = 24 }
        };

        var sortedByDescendingLINQ = students.OrderByDescending(x => x.Name).ThenByDescending(x => x.SecondName);
        foreach (var student in sortedByDescendingLINQ)
        {
            Console.WriteLine("{0} {1} {2}", student.Name, student.SecondName, student.Age);
        }

        Console.WriteLine("------------------");

        var sortedByDescendingLambda =
            from student in students
            orderby student.Name descending, student.SecondName descending
            select student;

        foreach (var student in sortedByDescendingLambda)
        {
            Console.WriteLine("{0} {1} {2}", student.Name, student.SecondName, student.Age);
        }
    }
}
