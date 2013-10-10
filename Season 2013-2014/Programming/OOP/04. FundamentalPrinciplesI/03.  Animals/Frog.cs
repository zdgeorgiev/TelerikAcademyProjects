using System;

public class Frog : Animal
{
    private const string AnimalSound = "Quak";

    public Frog(string name, int age, Sex sex)
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