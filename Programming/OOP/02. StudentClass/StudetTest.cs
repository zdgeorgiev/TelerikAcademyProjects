using System;

class StudetTest
{
    static void Main()
    {
        Student[] students = new Student[3];

        Student firstStudent = new Student("Valio", Specialty.IT);
        students[0] = firstStudent;

        Student secondStudent = new Student("Kolio", "Mehano", "ddd@ddd.ddd", Specialty.Biologie);
        students[1] = secondStudent;

        foreach (Student studentInfo in students)
        {
            Console.WriteLine(studentInfo);
        }
    }
}
