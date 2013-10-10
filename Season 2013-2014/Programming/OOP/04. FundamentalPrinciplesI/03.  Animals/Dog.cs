using System;

public class Dog : Animal
{
    private const string DogSound = "Roaar";

    public Dog(string name, int age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override string Scream()
    {
        return DogSound;
    }

    public override string ToString()
    {
        return "Animal - " + this.GetType().Name + ", " + base.ToString();
    }
}