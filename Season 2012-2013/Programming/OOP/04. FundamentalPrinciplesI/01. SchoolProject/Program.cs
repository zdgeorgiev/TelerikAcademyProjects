using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Kolio", "Stefanov", "Kirilov", 60),
            new Student("Karamfil", "Ivanov", "Stefanov", 30),
            new Student("Georgi", "Trendafilov", "Dimitrov", 13),
            new Student("Ivan", "Kolev", "Kolev", 18)
        };

        List<Teacher> teachers = new List<Teacher>
        {
            new Teacher("Elka", "Mileva", "Terzieva"),
            new Teacher("Ambar", "Jekova", "Kraleva"),
            new Teacher("Angela", "Arabadjieva", "Terzieva"),
            new Teacher("Snejanka", "Stavreva", "Iordanova"),
            new Teacher("Stanka", "Staneva", "Plachkova")
        };

        List<Disciplines> disciplines = new List<Disciplines>
        {
            new Disciplines("OOP", 60, 1),
            new Disciplines("English", 44, 90),
            new Disciplines("ComputerScience", 60, 28),
            new Disciplines("Geodesia", 16, 27),
            new Disciplines("History", 75, 70),
            new Disciplines("Biologye", 16, 58)
        };

        teachers[0].AddDiscripline(disciplines[0]);
        teachers[0].AddDiscripline(disciplines[1]);
        teachers[0].AddDiscripline(disciplines[2]);
        teachers[1].AddDiscripline(disciplines[1]);
        teachers[2].AddDiscripline(disciplines[3]);
        teachers[3].AddDiscripline(disciplines[5]);
        teachers[3].AddDiscripline(disciplines[0]);

        Class firstGradeClass = new Class(students, teachers, 50);

        List<Class> allClasses = new List<Class>();
        allClasses.Add(firstGradeClass);

        School BasicSchool = new School(allClasses);
    }
}

//We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number.
//Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises.
//Both teachers and students are people. Students, classes, teachers and disciplines
//could have optional comments (free text block).
//Your task is to identify the classes (in terms of  OOP) and their
//attributes and operations, encapsulate their fields, define the class
// hierarchy and create a class diagram with Visual Studio.
