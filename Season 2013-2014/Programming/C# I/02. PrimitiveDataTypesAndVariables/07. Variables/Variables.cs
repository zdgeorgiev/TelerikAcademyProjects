using System;

class Variables
{
    static void Main(string[] args)
    {
        string firstString = "Hello ";
        string secondString = "World!";
        object resultAsObject = firstString + secondString;
        string resultAsString = (string)resultAsObject;

        Console.WriteLine(resultAsString);
    }
}

//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of
//the first two variables (mind adding an interval). Declare a third
//string variable and initialize it with the value of the object variable (you should perform type casting).