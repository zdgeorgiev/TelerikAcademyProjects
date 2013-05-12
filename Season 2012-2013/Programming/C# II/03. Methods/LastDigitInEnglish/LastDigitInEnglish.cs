using System;

class LastDigitInEnglish
{
    static string LastDigit(int number)
    {
        number = number % 10;
        string word = "";

        switch (number)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
            default: word = "Invalid Number";
                break;
        }
        return word;

    }

    static void Main()
    {
        Console.Write("Enter number > 100  == ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit of {0} is {1}", n, LastDigit(n));
    }
}


//Write a method that returns the last digit of given integer as an English word.
//Examples: 512  "two", 1024  "four", 12309  "nine".
