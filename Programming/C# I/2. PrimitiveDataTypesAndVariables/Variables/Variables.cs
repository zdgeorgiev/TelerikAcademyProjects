using System;

class Variables
{
    static void Main()
    {
        string hello = "Hello ";
        string world = "world!";
        object full = hello + world;
        string combine = (string)full;
        Console.WriteLine(combine);
    }
}


//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
