using System;

class GreaterTwoNumbers
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        
        if (first > secound)
        {
            Console.WriteLine("{0} is greater than {1}", first, secound);
        }
        else if (first < secound)
        {
            Console.WriteLine("{0} is greater than {1}", secound, first);
        }
    }
}

//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
