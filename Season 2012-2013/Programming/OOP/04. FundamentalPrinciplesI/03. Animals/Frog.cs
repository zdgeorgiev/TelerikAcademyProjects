using System;

class Frog : Animal, ISound
{
    public Frog(string name, int age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override string Scream()
    {
        return string.Format("Quak");
    }
}