using System;

class Program
{
    static void Main()
    {
        Student student1 = new Student("Kolio", "Stefanov", "Marinov", 50, null, 0, null, null, Faculty.FMI, Specialty.ComputerScience);
        Student student2 = new Student("Qnislav", "Jekov", "Hristov", 40, null, 0, null, null, Faculty.FMI, Specialty.ComputerScience);
        Student student3 = new Student("Limon", "Qbulkov", "Maslinov", 44, null, 0, null, null, Faculty.FMI, Specialty.ComputerScience);
        Student student4 = new Student("Aimon", "Qbulkov", "Maslinov", 33, null, 0, null, null, Faculty.FMI, Specialty.ComputerScience);
        Student student5 = new Student("Aimon", "Qbulkov", "Maslinov", 32, null, 0, null, null, Faculty.FMI, Specialty.ComputerScience);
        Student student6 = new Student("Bimon", "Qbulkov", "Maslinov", 222, null, 0, null, null, Faculty.FMI, Specialty.ComputerScience);

        Student st22 = student1.Clone();
        //Console.WriteLine(st22);

        Student[] students = new Student[] { student1, student2, student3, student4, student5, student6};

        Array.Sort(students);
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}


