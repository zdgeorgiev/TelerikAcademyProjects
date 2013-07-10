using System;

class StringSum
{
    static void Main(string[] args)
    {
        string simpleString = "43 68 9 23 318";

        var splittedNumbers = simpleString.Split(' ');

        int sum = 0;

        for (int i = 0; i < splittedNumbers.Length; i++)
        {
            sum += int.Parse(splittedNumbers[i]);
        }

        Console.WriteLine(sum);
    }
}

//You are given a sequence of positive integer values written into a string,
//separated by spaces. Write a function that reads these values
//from given string and calculates their sum. Example:
//        string = "43 68 9 23 318"  result = 461