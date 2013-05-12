using System;
using System.Collections.Generic;

class School
{
    public List<Class> Classes { get; set; }

    public global::Class Class
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }

    public School(List<Class> classes)
    {
        this.Classes = classes;
    }

    public void RemoveClass(Class @class) //override
    {
        this.Classes.Add(@class);
    }

    public void AddClass(Class @class)
    {
        this.Classes.Remove(@class);
    }
}
