using System;
using System.Text;

class ReverseNumber
{
    static int Reverse(int number)
    {
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

    static void Main(string[] args)
    {
        Console.Write("Enter a number : \t");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Reversed number : \t{0}", Reverse(number));
    }
}
//Write a method that reverses the digits of given decimal number. Example: 256  652