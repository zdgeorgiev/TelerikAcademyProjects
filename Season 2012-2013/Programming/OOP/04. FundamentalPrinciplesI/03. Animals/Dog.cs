using System;

class Dog : Animal, ISound
{
    public Dog(string name, int age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override string Scream()
    {
        return string.Format("Baoo");
    }
}