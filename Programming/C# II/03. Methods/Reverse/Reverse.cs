using System;

    class Reverse
    {
        static int ReverseTheNumber(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            return reversed;
        }

        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Enter number!");
            Console.Write("number= ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Reversed number is {0}", ReverseTheNumber(number));
        }
    }


//Write a method that reverses the digits of given decimal number. Example: 256  652
