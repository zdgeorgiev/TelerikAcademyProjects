using System;

public abstract class Animal : ISound
{
    private string name;
    private int age;

    public Sex Sex { get; set; }

    public Animal(string name, int age, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Invalid age the the animal");
            }

            this.age = value;
        }
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name of the animal is invalid");
            }

            this.name = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Name - {0}, Age - {1}, Sex - {2}",
            this.Name, this.Age, this.Sex);
    }

    public abstract string Scream();
}