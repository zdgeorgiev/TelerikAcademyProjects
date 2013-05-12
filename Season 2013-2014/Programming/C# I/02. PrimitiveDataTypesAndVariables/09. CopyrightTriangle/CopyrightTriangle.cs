using System;
using System.Text;

class CopyrightTriangle
{
    /// <summary>
    /// This program wont work for other numbers because
    /// the task isnt given correct. !
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n = 9;

        for (int i = 0; i < n / 2 + 1; i++)
        {
            int leftSpaces = n / 2 - i;
            char copyRight = '©';
            int rightSpaces = leftSpaces;

            if (i % 2 == 0)
            {
                Console.Write(new string(' ', leftSpaces));
                Console.Write(new string(copyRight, i + 1));
                Console.Write(new string(' ', rightSpaces));
                Console.WriteLine();
            }
        }
    }
}

//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol.
//Note: the © symbol may be displayed incorrectly.