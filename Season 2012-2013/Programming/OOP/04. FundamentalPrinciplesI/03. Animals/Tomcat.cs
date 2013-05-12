using System;

class Tomcat : Cat
{
    public Tomcat(string name, int age) : base(name, age, Sex.Male)
    {
    }

    public override string Scream()
    {
        return string.Format("MEOW!");
    }
}