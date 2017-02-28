using System;

class MultiFormat
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0:D}", number);
        Console.WriteLine("{0:X}", number);
        Console.WriteLine("{0:P}", number);
        Console.WriteLine("{0:E5}", number);
    }
}

//Write a program that reads a number and prints it as
//a decimal number, hexadecimal number, percentage and 
//in scientific notation. Format the output aligned right in 15 symbols.