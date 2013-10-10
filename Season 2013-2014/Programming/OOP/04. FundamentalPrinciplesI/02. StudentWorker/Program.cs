using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Student> allStudents = new List<Student>()
        {
            new Student("Stefan", "Pesho", 10),
            new Student("Gloriq", "Kirova", 3),
            new Student("Aleksiq", "Stoqnova", 10),
            new Student("Stoqn", "Dimitrov", 6),
            new Student("Stefani", "Ivanova", 12),
            new Student("Gabriela", "Georgieva", 11),
            new Student("Zlatan", "Kostov", 2),
            new Student("Mitko", "Maistorov", 8),
            new Student("Borko", "Meshkov", 10),
            new Student("Kiro", "Ivanovich", 1),
        };
        List<Worker> allWorkers = new List<Worker>()
        {
            new Worker("Stefan,", "Georgiev", 531423, 1),
            new Worker("Gloriq", "Stefanova", 53132423, 10),
            new Worker("Aleksiq", "Stefanova", 53645423, 11),
            new Worker("Stoqn", "Kirov", 535423, 2),
            new Worker("Stefani", "Stefanova", 53431223, 10),
            new Worker("Gabriela", "D;3", 5323, 3),
            new Worker("Zlatan", "Ivanov", 53614323, 6),
            new Worker("Mitko", "Zlatanov", 5345423, 13),
            new Worker("Borko", "Dimitrov", 53321423, 13),
            new Worker("Kiro", "Iordanov", 53667423, 15),
        };

        var sortedStudents = allStudents.OrderByDescending(student => student.Grade);
        var sortedWorkers = allWorkers.OrderByDescending(worker => worker.MoneyPerHour());

        List<Human> allPeoples = new List<Human>();

        //Merge the lists
        allPeoples.AddRange(allStudents);
        allPeoples.AddRange(allWorkers);

        var sortedHumans = allPeoples.OrderByDescending(people => people.FirstName)
            .ThenByDescending(people => people.LastName);

        foreach (var human in sortedHumans)
        {
            Console.WriteLine(human);
        }
    }
}

//Define abstract class Human with first name and last name. Define new class Student
//which is derived from Human and has new field – grade. Define class Worker
//derived from Human with new property WeekSalary and WorkHoursPerDay and
//method MoneyPerHour() that returns money earned by hour by the worker.
//Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in 
//ascending order (use LINQ or OrderBy() extension method). Initialize
//a list of 10 workers and sort them by money per hour in descending
//order. Merge the lists and sort them by first name and last name.