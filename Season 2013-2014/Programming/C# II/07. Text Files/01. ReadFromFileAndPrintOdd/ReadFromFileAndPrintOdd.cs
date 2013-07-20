using System;
using System.IO;

class ReadFromFileAndPrintOdd
{
    static void Main(string[] args)
    {
        using (var reader = new StreamReader("../../text.txt"))
        {
            int lineCounter = 1;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (lineCounter % 2 != 0)
                {
                    Console.WriteLine(line);
                }

                line = reader.ReadLine();
                lineCounter++;
            }
        }
    }
}

//Write a program that reads a text file and prints on the console its odd lines.