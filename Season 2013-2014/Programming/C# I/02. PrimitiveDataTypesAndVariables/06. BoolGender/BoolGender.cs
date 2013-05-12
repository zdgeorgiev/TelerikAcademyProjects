using System;
using System.Linq;

class BoolGender
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey, please enter your gender!");
        Console.WriteLine("M/F");
        string input = Console.ReadLine();
        string[] validAnswers = new string[] { "m", "male", "f", "female" };
        bool isValidGender = false;

        do
        {
            if (validAnswers.Contains(input.ToLower()))
            {
                isValidGender = true;

                //If first letter in input is m you are male
                if (input[0].ToString() == "m")
                {
                    Console.WriteLine("You are male.");
                }
                else
                {
                    Console.WriteLine("You are female.");
                }
                break;
            }
            else
            {
                Console.WriteLine("Sorry, but input is wrong!");
                Console.WriteLine("Please enter again!");
                input = Console.ReadLine();
            }
        }
        while (!isValidGender);
    }
}

//Declare a boolean variable called isFemale and
//assign an appropriate value corresponding to your gender.