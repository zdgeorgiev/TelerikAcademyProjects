using System;
using System.Collections.Generic;

public class School
{
    public List<Class> allClasses { get; set; }

    public School()
    {
        this.allClasses = new List<Class>();
    }

    public void AddClass(Class currentClass)
    {
        if (this.allClasses.Contains(currentClass))
        {
            throw new ArgumentException("This school already contains this class");
        }

        this.allClasses.Add(currentClass);
    }

    public void RemoveClass(Class currentClass)
    {
        if (!this.allClasses.Contains(currentClass))
        {
            throw new ArgumentException("This school doesnt contains this class");
        }

        this.allClasses.Remove(currentClass);
    }
}