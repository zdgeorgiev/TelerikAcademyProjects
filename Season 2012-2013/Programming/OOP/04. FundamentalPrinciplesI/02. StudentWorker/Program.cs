using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Worker> workers = new List<Worker>()
        {
            new Worker("Kolio", "Petrov", 700, 61),
            new Worker("Bojidar", "Petrov", 1500, 891),
            new Worker("Daniel", "Petrov", 7880, 102),
            new Worker("Angel", "Ivanov", 44444, 612),
            new Worker("Petar", "Trifonov", 30, 2114),
            new Worker("Kolio", "Petrov", 666, 100),
            new Worker("Galin", "Kirilov", 1500, 879),
            new Worker("Stefan", "Petrov", 18, 12),
            new Worker("Lazar", "Pulev", 44444, 9811),
            new Worker("Gabriel", "Petrov", 30, 400),
            new Worker("Qvor", "Angelov", 666, 871)
        };

        List<Student> students = new List<Student>()
        {
            new Student("Kolio", "Petrov", 12),
            new Student("Bojidar", "Petrov", 9),
            new Student("Daniel", "Petrov", 12),
            new Student("Angel", "Ivanov", 11),
            new Student("Petar", "Trifonov", 8),
            new Student("Kolio", "Petrov", 11),
            new Student("Galin", "Kirilov", 7),
            new Student("Stefan", "Petrov", 9),
            new Student("Lazar", "Pulev", 6),
            new Student("Gabriel", "Petrov", 12),
            new Student("Qvor", "Angelov", 11)
        };

        var sortedByGrade = students.OrderBy(x => x.Grade); //sort students by grade
        foreach (var item in sortedByGrade)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------------------------");
        
        var sorted = workers.OrderByDescending(x => x.MoneyPerHour()); //sort workers by MoneyPerHour
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------------------------");

        List<Human> humans = new List<Human>(); //merge list with humans and students
        humans.AddRange(students); //add students list in humans list
        humans.AddRange(workers); //add workers list in humans list

        var sortedHumansByName = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName); //sort by FirstName then by SecondName
        foreach (var item in sortedHumansByName)
        {
            Console.WriteLine(item);
        }

    }
}