using System;
using System.Collections.Generic;

public class Teacher : People
{
    private readonly List<Discipline> allDisciplines;

    public Teacher(string name) : base(name)
    {
        this.allDisciplines = new List<Discipline>();
    }

    public List<Discipline> AllDisctiplines
    {
        get { return this.allDisciplines; }
    }

    public void AddDiscipline(Discipline dis)
    {
        if (allDisciplines.Contains(dis))
        {
            throw new ArgumentException(string.Format("Current discipline {0} is already added"), dis.Name);
        }

        this.allDisciplines.Add(dis);
    }

    public void RemoveDiscipline(Discipline dis)
    {
        if (!allDisciplines.Contains(dis))
        {
            throw new ArgumentException(string.Format("Current discipline {0} not found"), dis.Name);
        }

        this.allDisciplines.Remove(dis);
    }
}