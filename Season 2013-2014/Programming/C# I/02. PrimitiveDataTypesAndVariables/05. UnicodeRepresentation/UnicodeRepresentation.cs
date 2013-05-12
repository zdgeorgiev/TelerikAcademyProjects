using System;

class UnicodeRepresentation
{
    static void Main(string[] args)
    {
        int firstValue = 72;
        Console.WriteLine(firstValue.ToString("X4"));

        char charValue = '\u0048';
        Console.WriteLine(charValue);
    }
}

//Declare a character variable and assign it with the symbol
//that has Unicode code 72. Hint: first use the Windows Calculator
//to find the hexadecimal representation of 72.