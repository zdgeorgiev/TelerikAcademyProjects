using System;

class Program
{
    static void Main(string[] args)
    {
        Person firstPerson = new Person("Pesho", 50);
        Person secondPerson = new Person("Stefan");

        Console.WriteLine(firstPerson);
        Console.WriteLine(secondPerson);
    }
}