using System;

class Kitten : Cat
{
    public Kitten(string name, int age) //constructor ask only for name and age
        : base(name, age, Sex.Female) //make the sex default from base class
    {
    }

    public override string Scream()
    {
        return string.Format("Miayy");
    }
}