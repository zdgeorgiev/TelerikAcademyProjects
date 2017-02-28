using System;

public class Tomcat : Cat
{
    private const string AnimalSound = "MEOW";

    public Tomcat(string name, int age)
        : base(name, age, Sex.Male)
    {
    }

    public override string Scream()
    {
        return AnimalSound;
    }
}