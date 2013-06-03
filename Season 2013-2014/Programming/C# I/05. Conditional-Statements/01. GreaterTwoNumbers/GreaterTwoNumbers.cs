using System;

class GreaterTwoNumbers
{
    static void Main(string[] args)
    {
        Console.Write("First Number - ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second Number - ");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            int tempValue = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempValue;
        }

        Console.WriteLine("First number - {0}", firstNumber);
        Console.WriteLine("Second number - {0}", secondNumber);
    }
}

//Write an if statement that examines two integer variables and
//exchanges their values if the first one is greater than the second one.