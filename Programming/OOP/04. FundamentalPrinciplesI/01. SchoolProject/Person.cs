using System;

public class Person
{
    public string FirstName { get; private set; }
    public string SecondName { get; private set; }
    public string LastName { get; private set; }

    public Person(string firstName, string secondName, string lastName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.LastName = lastName;
    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2}", this.FirstName, this.SecondName, this.LastName);
    }
}