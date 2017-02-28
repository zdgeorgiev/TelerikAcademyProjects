using System;
using System.IO;

class GetValuesBetweenXMLTags
{
    public const string OpenedTag = "<";
    public const string ClosedTag = ">";

    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../XML.txt");

        using (StreamWriter writer = new StreamWriter("../../XMLValues.txt"))
        {
            using (reader)
            {
                string line = reader.ReadLine();

                for (int i = 0; i < line.Length - 1; i++)
                {
                    //If find a closed tag and next char isnt starts a new tag
                    if (line.Substring(i, 1) == ClosedTag &&
                        line.Substring(i + 1, 1) != OpenedTag)
                    {
                        //Get the lenght of the value
                        int valueLenght = 0;

                        for (int j = i + 1; j < line.Length; j++)
                        {
                            if (line.Substring(j, 1) != OpenedTag)
                            {
                                valueLenght++;
                            }
                            else
                            {
                                string tagValue = line.Substring(i + 1, valueLenght);
                                writer.WriteLine(tagValue);

                                break;
                            }
                        }
                    }
                }

                Console.WriteLine("Finished.");
            }
        }
    }
}

//Write a program that extracts from given XML file all the text without the tags. 