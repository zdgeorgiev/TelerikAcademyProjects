using System;
using System.Text;

class UnicodeTable
{
    static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        for (int i = 0; i < 257; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}
