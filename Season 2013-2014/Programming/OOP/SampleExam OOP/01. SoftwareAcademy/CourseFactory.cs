using SoftwareAcademy;
using System;

public class CourseFactory : ICourseFactory
{
    public ITeacher CreateTeacher(string name)
    {
        Teacher teacher = new Teacher(name);

        return teacher;
    }

    public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
    {
        LocalCourse localCourse = new LocalCourse(name, teacher, lab);

        return localCourse;
    }

    public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
    {
        OffsiteCourse offSideCourse = new OffsiteCourse(name, teacher, town);

        return offSideCourse;
    }
}