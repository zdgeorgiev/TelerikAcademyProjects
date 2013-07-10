using System;

class FromBaseToBase
{
    /// <summary>
    /// In previous taks we implement all the different cases or different number
    /// systems that we need in this task.So to do not write them again we can use
    /// it directly from the solution by adding the references to all taks by right
    /// click to the References buttom and the 07.FromBaseToBase task and > Solution.
    /// Other think we need is that all the classes and methods must be public!
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        string number = Console.ReadLine();

        Console.Write("From what base : ");
        int fromBase = int.Parse(Console.ReadLine());

        Console.Write("To what base : ");
        int toBase = int.Parse(Console.ReadLine());

        if (fromBase == 2)
        {
            if (toBase == 10)
            {
                Console.WriteLine("Result in {0} base - {1}", toBase,
                        BinaryToDecimal.ConvertToDecimal(number));
            }
            else
            {
                Console.WriteLine("Result in {0} base - {1}", toBase,
                        BinaryToHex.ConvertToHex(number));
            }
        }
        else if (fromBase == 10)
        {
            if (toBase == 2)
            {
                Console.WriteLine("Result in {0} base - {1}", toBase,
                        DecimalToBinary.ConvertToBinary(int.Parse(number)));
            }
            else
            {
                Console.WriteLine("Result in {0} base - {1}", toBase,
                    DecimalToHex.ConvertToHex(int.Parse(number)));
            }
        }
        else
        {
            if (toBase == 2)
            {
                Console.WriteLine("Result in {0} base - {1}", toBase,
                    HexToBinary.ConvertToBinary(number));
            }
            else
            {
                Console.WriteLine("Result in {0} base - {1}", toBase,
                    HexToDecimal.ConvertToDecimal(number));
            }
        }
    }
}

//Write a program to convert from any numeral system of given
//base s to any other numeral system of base d (2 ≤ s, d ≤  16).