using System;
using System.Text;

class ThreeInOneProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program can solve these tasks : ");
        Console.WriteLine("1.Reverse a number");
        Console.WriteLine("2.Calculates the average of a sequence of integers");
        Console.WriteLine("3.Solves a linear equation a * x + b = 0");
        Console.Write("\nSelect any task (1, 2 or 3) : ");

        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.Write("\nEnter a number : ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Reversed number {0}", Reverse(number));
                break;
            case 2:
                Console.Write("\nHow much numbers? : ");
                int numbersCount = int.Parse(Console.ReadLine());

                int[] numbers = new int[numbersCount];

                for (int i = 0; i < numbers.Length; i++)
                {
			        Console.Write("{0}. = ", i + 1);
                    int currentNumber = int.Parse(Console.ReadLine());
                    numbers[i] = currentNumber;
                }

                Console.WriteLine("Average sum of the numbers = {0}", CalcAverage(numbers));
                break;
            case 3:
                Console.Write("\nEnter number for a : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter number for b : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("x = {0}", CalcLinearEquation(a, b));
                break;
            default:
                throw new ArgumentException(
                    "Invalid number operation");
        }
    }

    static int Reverse(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
                "Sorry but number to reversed cannot be negative");
        }

        if (number < 10)
        {
            return number;
        }

        StringBuilder result = new StringBuilder();

        while (number > 0)
        {
            int lastDigit = number % 10;
            number /= 10;

            result.Append(lastDigit);
        }

        return int.Parse(result.ToString());
    }

    static double CalcAverage(params int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException(
                "Sorry you cannot calculate average sum of null of empty array");
        }

        double totalSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            totalSum += numbers[i];
        }

        double average = totalSum / numbers.Length;

        return average;
    }

    static double CalcLinearEquation(double a, double b)
    {
        if (a == 0)
        {
            throw new ArgumentException("Sorry but 'a' cannot be 0");
        }

        double result = -b / a;

        return result;
    }
}

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0