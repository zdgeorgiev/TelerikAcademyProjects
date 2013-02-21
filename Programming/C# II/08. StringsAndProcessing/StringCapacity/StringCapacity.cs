using System;
using System.Text;

class StringCapacity
{
    static void Main()
    {
        int stringCapacity = 20;
        int stars = 0;
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        if (input.Length < stringCapacity)
        {
            stars = stringCapacity - input.Length;
            string starString = new string('*', stars);
            sb.Append(input);
            sb.Append(starString);
            Console.WriteLine(sb);
        }
        else
        {
            Console.WriteLine("Too Long text!");
        }
    }
}

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console.
