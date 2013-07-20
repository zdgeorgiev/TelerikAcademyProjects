using System;
using System.IO;

class ConcatTwoTexts
{
    static void Main(string[] args)
    {
        StreamReader firstFile = new StreamReader("../../text1.txt");
        StreamReader secondFile = new StreamReader("../../text2.txt");

        using (StreamWriter outputFile = new StreamWriter("../../output.txt"))
        {
            using (firstFile)
            {
                using (secondFile)
                {
                    string line = firstFile.ReadLine();

                    while (line != null)
                    {
                        outputFile.Write(line);
                        line = firstFile.ReadLine();
                    }

                    line = secondFile.ReadLine();

                    while (line != null)
                    {
                        outputFile.Write(line);
                        line = secondFile.ReadLine();
                    }

                    Console.WriteLine("Text files are concatenated.");
                }
            }
        }
    }
}

//Write a program that concatenates two text files into another text file.