using System;

abstract class Animal : ISound
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Sex Sex { get; set; }

    public Animal(string name, int age, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public override string ToString()
    {
        return string.Format("{0} is {1} years old {2}, {3}",
            this.Name, this.Age, this.GetType(), this.Sex); //GetType returns System.Type of the instance
    }

    public abstract string Scream();
}