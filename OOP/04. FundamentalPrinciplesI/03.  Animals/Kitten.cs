using System;

public class Kitten : Cat
{
    private const string AnimalSound = "Miyauu";

    public Kitten(string name, int age)
        : base(name, age, Sex.Female)
    {
    }

    public override string Scream()
    {
        return AnimalSound;
    }
}