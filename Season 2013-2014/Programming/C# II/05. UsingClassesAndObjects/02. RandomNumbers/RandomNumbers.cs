using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomGenerator.Next(100, 201));
        }
    }
}

//Write a program that generates and prints to the console 10 random values in the range [100, 200].