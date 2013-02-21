using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader readerFirstFile = new StreamReader(@"..\..\1.txt", Encoding.GetEncoding("windows-1251"));
        StreamReader readerSecondFile = new StreamReader(@"..\..\2.txt", Encoding.GetEncoding("windows-1251"));
        using (readerFirstFile)
        {
            StreamWriter writer = new StreamWriter(@"..\..\outputt.txt", false, Encoding.GetEncoding("windows-1251"));
            using (writer)
            {
                string s;
                while ((s = readerFirstFile.ReadLine()) != null)
                {
                    writer.WriteLine(s);
                }

            }

        }
        using (readerSecondFile)
        {
            StreamWriter writer = new StreamWriter(@"..\..\outputt.txt", true, Encoding.GetEncoding("windows-1251"));
            using (writer)
            {
                string s;
                while ((s = readerSecondFile.ReadLine()) != null)
                {
                    writer.WriteLine(s);
                }

            }

        }

    }
}

//Write a program that concatenates two text files into another text file.
