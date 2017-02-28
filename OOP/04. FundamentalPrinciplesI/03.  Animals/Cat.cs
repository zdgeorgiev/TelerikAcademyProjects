using System;

public class Cat : Animal
{
    private const string AnimalSound = "Meeeoow";

    public Cat(string name, int age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override string Scream()
    {
        return AnimalSound;
    }

    public override string ToString()
    {
        return "Animal - " + this.GetType().Name + ", " + base.ToString();
    }
}