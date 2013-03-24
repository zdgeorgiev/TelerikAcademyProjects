using System;

class Person
{
    public string Name { get; private set; }
    public byte? Age { get; private set; }

    public Person(string name, byte? age = null)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        //return this.Name and IF this.Age isnt null return this.Age.ToString() else N/A
        return string.Format("{0} {1}", this.Name, this.Age != null ? this.Age.ToString() : "N/A");
    }
}
