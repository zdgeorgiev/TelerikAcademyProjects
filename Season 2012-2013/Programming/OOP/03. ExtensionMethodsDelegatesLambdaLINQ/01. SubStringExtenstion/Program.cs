using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder str = new StringBuilder();
        str.Append("Az sum gosho ot pochivka i iskam da se naqm.");
        Console.WriteLine(str.Substring(-1, 10));
    }
}
