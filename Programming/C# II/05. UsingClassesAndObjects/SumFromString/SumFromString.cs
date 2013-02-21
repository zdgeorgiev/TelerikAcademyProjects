using System;

class SumFromString
{
    static void Main()
    {
        int sum = 0;
        string[] sequence = Console.ReadLine().Split(' ');

        for (int i = 0; i < sequence.Length; i++)
		{
			sum += int.Parse(sequence[i]);
		}

        Console.WriteLine("Sum = {0}", sum);
    }
}

//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461