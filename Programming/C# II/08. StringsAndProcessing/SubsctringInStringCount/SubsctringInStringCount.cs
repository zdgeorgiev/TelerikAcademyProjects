using System;

class SubsctringInStringCount
{
    static void Main()
    {
        string searchedWord = Console.ReadLine();
        string text = Console.ReadLine();
        int counter = 0;

        for (int i = 0; i < text.Length - searchedWord.Length - 1; i++)
        {
            if (text.Substring(i, searchedWord.Length).ToLower() == searchedWord.ToLower()) //ако индекса с дължината на думата съвпада с думата. 
            {
                counter++;
                i += searchedWord.Length - 1; // прескачаме дължината на търсената дума , "-1" тъйкато първата е намерена от if-а.
            }
        }
        Console.WriteLine("{0} times", counter);
    }
}


//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:
//
//      We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight.
//      So we are drinking all the day. We will move out of it in 5 days.
//
//	The result is: 9.
