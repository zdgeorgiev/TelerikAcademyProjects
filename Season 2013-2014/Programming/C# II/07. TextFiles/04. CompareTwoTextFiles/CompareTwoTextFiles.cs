using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class CompareTwoTextFiles
{
    static void Main(string[] args)
    {
        StreamReader firstText = new StreamReader("../../text1.txt");
        StreamReader secondText = new StreamReader("../../text2.txt");

        List<int> sameLines = new List<int>();
        List<int> diffLines = new List<int>();

        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            string firstTextLine = firstText.ReadLine();
            string secondTextLine = secondText.ReadLine();
            int line = 1;

            while (firstTextLine != null && secondTextLine != null)
            {
                if (firstTextLine == secondTextLine)
                {
                    sameLines.Add(line);
                }
                else
                {
                    diffLines.Add(line);
                }

                line++;
                firstTextLine = firstText.ReadLine();
                secondTextLine = secondText.ReadLine();
            }

            writer.WriteLine("Same lines " + string.Join(" ", sameLines.ToArray()));
            writer.WriteLine("Different lines " + string.Join(" ", diffLines.ToArray()));

            Console.WriteLine("Finished");
        }
    }
}

//Write a program that compares two text files line by line
//and prints the number of lines that are the same and the
//number of lines that are different. Assume the files have equal number of lines.