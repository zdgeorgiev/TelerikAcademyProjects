using System;
using System.Text;

class CopyrightTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        //numbers of rows and cols
        Console.Write("Enter a number for rows and cols. ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < n ; i++)
        {
            int leftSpaces = n - i - 1;
            char copyRight = '\u00A9';
            int rightSpaces = leftSpaces;

            Console.Write(new string(' ', leftSpaces));
            Console.Write(new string(copyRight, i + 1));
            Console.Write(new string(' ', rightSpaces));
            Console.WriteLine();
        }
    }
}

//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol.
//Note: the © symbol may be displayed incorrectly.