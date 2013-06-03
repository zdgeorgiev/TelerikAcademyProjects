using System;

class CheckTheSignOfASum
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if ((firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
            || (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
            || (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
            || (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0))
        {
            Console.WriteLine('-');
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}

//Write a program that shows the sign (+ or -) of the product of three
//real numbers without calculating it. Use a sequence of if statements.