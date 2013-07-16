using System;
using System.IO;

class InsertLines
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(@"D:\CSharpApps\13. Text Files\03. InsertLines\InsertLines.cs");

        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            string line = reader.ReadLine();
            int lineNumber = 1;

            while (line != null)
            {
                writer.WriteLine("{0,2}. {1}", lineNumber, line);
                line = reader.ReadLine();
                lineNumber++;
            }

            Console.WriteLine("Finished.");
        }
    }
}

//Write a program that reads a text file and inserts line numbers 
//in front of each of its lines. The result should be written to another text file.