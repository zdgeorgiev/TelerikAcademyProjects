using System;

class HexValueForInt
{
    static void Main(string[] args)
    {
        int value = 254;
        Console.WriteLine(value.ToString("X4"));

        int secondValue = '\u00FE';
        Console.WriteLine(secondValue);
    }
}

//Declare an integer variable and assign it with the value 254
//in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.