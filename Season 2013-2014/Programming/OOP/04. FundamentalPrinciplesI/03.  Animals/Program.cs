using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> allAnimals = new List<Animal>()
        {
            new Kitten("Penka", 15),
            new Tomcat("Stoqn", 5),
            new Dog("Kolio", 23, Sex.Male),
            new Frog("Stefko", 2, Sex.Male),
            new Cat("Pepa", 25, Sex.Male)
        };

        foreach (Animal animal in allAnimals)
        {
            Console.WriteLine(animal);
            Console.WriteLine(animal.Scream());
        }

        Console.WriteLine("Average age - {0}", CalcAverageAge(allAnimals));
    }

    static double CalcAverageAge(List<Animal> animals)
    {
        double age = 0;

        foreach (Animal animal in animals)
        {
            age += animal.Age;
        }

        return Math.Round(age / animals.Count, 2);
    }
}