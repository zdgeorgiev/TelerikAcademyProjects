using System;

class Brackets
{
    static void Main(string[] args)
    {
        string expression = Console.ReadLine();

        bool isCorrect = false;
        int openBracketCounter = 0;
        int closedBracketCounter = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                openBracketCounter++;
            }
            else if (expression[i] == ')')
            {
                closedBracketCounter++;
            }
        }

        if (openBracketCounter == closedBracketCounter)
        {
            isCorrect = true;
        }

        Console.WriteLine("Is brackets set correctly for this expression : {0}"
            , isCorrect);
    }
}

//Write a program to check if in a given expression
//the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).