using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Dog[] dogs = new Dog[]
        {
            new Dog("Sharo", 5, Sex.Male),
            new Dog("Joe", 10, Sex.Male),
            new Dog("Jesica", 3, Sex.Female),
            new Dog("Albena", 8, Sex.Female),
            new Dog("Pesho", 13, Sex.Male)
        };

        Tomcat[] tomcats = new Tomcat[]
        {
            new Tomcat("Petar", 5),
            new Tomcat("Bekham", 3),
            new Tomcat("Oliver", 11),
            new Tomcat("Mitko", 7),
            new Tomcat("Kaloqn", 2),
        };

        var averageAgeDogs = dogs.Average(animal => animal.Age);
        Console.WriteLine("Average age in dogs - {0}", averageAgeDogs);

        var averageAgeTomcats = tomcats.Average(animal => animal.Age);
        Console.WriteLine("Average age in tomcats - {0}", averageAgeTomcats);

        Animal[] animals = new Animal[]
        {
            new Dog("Sharo", 5, Sex.Male),
            new Tomcat("Bekham", 3),
            new Kitten("Mariika", 5),
            new Frog("Kermit", 30, Sex.Male)
        };
        Console.WriteLine("---------------------------");
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal);
        }
        Console.WriteLine("---------------------------");
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Scream());
        }
    }
}
