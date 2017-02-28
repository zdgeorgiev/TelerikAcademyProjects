using System;

class GetMaxMethod
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }

        return secondNumber;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter first numbers : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second numbers : ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third numbers : ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(firstNumber, GetMax(secondNumber, thirdNumber)));
    }
}

//Write a method GetMax() with two parameters that returns
//the bigger of two integers. Write a program that reads 3 integers
//from the console and prints the biggest of them using the method GetMax().