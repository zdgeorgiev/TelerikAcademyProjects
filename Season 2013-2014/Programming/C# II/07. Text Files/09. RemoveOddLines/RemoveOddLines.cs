using System;
using System.IO;
using System.Text;

class RemoveOddLines
{
    static void Main(string[] args)
    {
        StringBuilder result = new StringBuilder();

        using (StreamReader reader = new StreamReader("../../input.txt"))
        {
            int lineCount = 1;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (lineCount % 2 != 0)
                {
                    result.AppendLine(line);
                }

                line = reader.ReadLine();
                lineCount++;
            }
        }

        using (StreamWriter writer = new StreamWriter("../../input.txt"))
        {
            writer.WriteLine(result);

            Console.WriteLine("Finished.");
        }
    }
}

//Write a program that deletes from given text
//file all odd lines. The result should be in the same file.