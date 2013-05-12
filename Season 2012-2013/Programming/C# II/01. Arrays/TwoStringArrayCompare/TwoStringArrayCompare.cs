using System;

class TwoStringArrayCompare
{
    static void Main()
    {
        string[] firstArray = { "a", "b", "c", "d", "e", "f" };
        string[] secondArray = { "a", "b", "c", "d", "e", "f" };

        bool areEqual = true;

        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
            Console.WriteLine("The two arrays are equal: {0}", areEqual);
        }
        else
        {
            areEqual = false;
            Console.WriteLine("The two arrays are equal: {0}", areEqual);
        }
    }
}


//Write a program that compares two char arrays lexicographically (letter by letter).