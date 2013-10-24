using System;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Kolio", "Stefanov", "Marinov", 50, null, 0, null, null, Specialty.ComputerScience, University.MedicalUniversity, Faculty.MedicalFac);
        Student student2 = new Student("Qnislav", "Jekov", "Hristov", 40, null, 0, null, null, Specialty.ComputerScience, University.TechnicalUniversity, Faculty.MedicalFac);
        Student student3 = new Student("Limon", "Qbulkov", "Maslinov", 44, null, 0, null, null, Specialty.ComputerScience ,University.MedicalUniversity, Faculty.FacultyOfLaw);
        Student student4 = new Student("Aimon", "Qbulkov", "Maslinov", 33, null, 0, null, null, Specialty.ComputerScience, University.MedicalUniversity, Faculty.FMI);
        Student student5 = new Student("Aimon", "Qbulkov", "Maslinov", 32, null, 0, null, null, Specialty.ComputerScience, University.SofiaUniversity, Faculty.FacultyOfLaw);
        Student student6 = new Student("Bimon", "Qbulkov", "Maslinov", 222, null, 0, null, null, Specialty.ComputerScience, University.TechnicalUniversity, Faculty.FMI);

        Student st22 = student1.Clone();
        //Console.WriteLine(student1);
        //Console.WriteLine(st22);

        Student[] students = new Student[] { student1, student2, student3, student4, student5, student6 };

        Array.Sort(students);
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}