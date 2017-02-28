using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class SortNamesFromFile
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../input.txt");

        List<string> allNames = new List<string>();

        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    allNames.Add(line);
                    line = reader.ReadLine();
                }

                allNames.Sort();

                StringBuilder result = new StringBuilder();
                foreach (var name in allNames)
                {
                    result.AppendLine(name);
                }

                writer.WriteLine(result);

                Console.WriteLine("Finished.");
            }
        }
    }
}

//Write a program that reads a text file containing a list
//of strings, sorts them and saves them to another text file. Example:

//Ivan		->   	George
//Peter		->   	Ivan
//Maria		->   	Maria
//George    ->   	Peter