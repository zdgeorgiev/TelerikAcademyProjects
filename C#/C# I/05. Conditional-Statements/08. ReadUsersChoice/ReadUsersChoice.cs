using System;

class ReadUsersChoice
{
    static void Main(string[] args)
    {
        string userInput = Console.ReadLine();

        int intVariable;
        double doubleVariable;

        if (int.TryParse(userInput, out intVariable))
        {
            intVariable = int.Parse(userInput) + 1;
            Console.WriteLine(intVariable);
        }
        else if (double.TryParse(userInput, out doubleVariable))
        {
            doubleVariable = double.Parse(userInput) + 1;
            Console.WriteLine(doubleVariable);
        }
        else
        {
            Console.WriteLine(userInput + "*");
        }
    }
}

//Write a program that, depending on the user's choice inputs
//int, double or string variable. If the variable is integer or
//double, increases it with 1. If the variable is string, appends
//"*" at its end. The program must show the value of
//that variable as a console output. Use switch statement.