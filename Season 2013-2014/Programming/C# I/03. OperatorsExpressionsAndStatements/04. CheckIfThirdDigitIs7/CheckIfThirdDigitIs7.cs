using System;

class CheckIfThirdDigitIs7
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int searcherNumber = int.MinValue;

        while (number > 10)
        {
            searcherNumber = number % 10;
            number /= 10;
        }

        if (searcherNumber == 7)
        {
            Console.WriteLine("Hooray the second digit left to right is 7.");
        }
        else
        {
            Console.WriteLine("Sorry but second digit left to right isnt 7 its {0}.", searcherNumber);
        }
    }
}

//Write an expression that checks for given integer 
//if its third digit (right-to-left) is 7. E. g. 1732  true.
