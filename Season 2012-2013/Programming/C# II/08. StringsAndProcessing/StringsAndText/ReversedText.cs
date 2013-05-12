using System;

class ReversedText
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] output = input.ToCharArray();
        Array.Reverse(output);
        Console.WriteLine(output);
    }
}

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".
