using System;

class StarString
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        if (text.Length < 20)
        {
            int remaining = 20 - text.Length;

            Console.Write(text);
            Console.Write(new string('*', remaining));
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(text);
        }
    }
}

//Write a program that reads from the console a string
//of maximum 20 characters. If the length of the string
//is less than 20, the rest of the characters should be 
//filled with '*'. Print the result string into the console.