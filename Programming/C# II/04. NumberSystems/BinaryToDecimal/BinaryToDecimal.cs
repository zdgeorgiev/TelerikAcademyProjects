using System;
 
class BinaryToDecimal
{ 
    static void Main()
    {
        string Binary = Convert.ToString(Console.ReadLine());
        int decimalNumber = 0;

        for (int i = 0; i < Binary.Length ; i++)
        {
            if (Binary[Binary.Length - i - 1] == '0')
            {
                continue;
            }
            decimalNumber += (int)Math.Pow(2, i); 
        }

        Console.WriteLine("{0} - {1}", Binary, decimalNumber);
    }
}

//Write a program to convert binary numbers to their decimal representation.


//11001110