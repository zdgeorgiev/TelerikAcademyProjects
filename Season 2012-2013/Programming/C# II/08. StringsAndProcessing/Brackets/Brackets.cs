using System;

class Brackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] inputArray = input.ToCharArray();
        int brackets = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] == '(')
            {
                brackets++;
            }

            else if (inputArray[i] == ')')
            {
                brackets--;
            }

            if (brackets < 0)
            {
                break;
            }
        }

        if (brackets == 0)
        {
            Console.WriteLine("The expression is correct.");
        }
        else
        {
            Console.WriteLine("The expression is incorrect.");
        }
    }
}

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
