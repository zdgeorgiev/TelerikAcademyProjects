using System;
using System.Text;

class Sheets
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] requiredSheets = new string[]
        {
            "A10",
            "A9",
            "A8",
            "A7",
            "A6",
            "A5",
            "A4",
            "A3",
            "A2",
            "A1",
            "A0",
        };

        while (n > 0)
        {
            if (n >= 1024)
            {
                int index = Array.IndexOf(requiredSheets, "A0");
                n -= 1024;
                requiredSheets[index] = "";
            }
            if (n >= 512)
            {
                int index = Array.IndexOf(requiredSheets, "A1");
                n -= 512;
                requiredSheets[index] = "";
            }
            if (n >= 256)
            {
                int index = Array.IndexOf(requiredSheets, "A2");
                n -= 256;
                requiredSheets[index] = "";
            }
            if (n >= 128)
            {
                int index = Array.IndexOf(requiredSheets, "A3");
                n -= 128;
                requiredSheets[index] = "";
            }
            if (n >= 64)
            {
                int index = Array.IndexOf(requiredSheets, "A4");
                n -= 64;
                requiredSheets[index] = "";
            }
            if (n >= 32)
            {
                int index = Array.IndexOf(requiredSheets, "A5");
                n -= 32;
                requiredSheets[index] = "";
            }
            if (n >= 16)
            {
                int index = Array.IndexOf(requiredSheets, "A6");
                n -= 16;
                requiredSheets[index] = "";
            }
            if (n >= 8)
            {
                int index = Array.IndexOf(requiredSheets, "A7");
                n -= 8;
                requiredSheets[index] = "";
            }
            if (n >= 4)
            {
                int index = Array.IndexOf(requiredSheets, "A8");
                n -= 4;
                requiredSheets[index] = "";
            }
            if (n >= 2)
            {
                int index = Array.IndexOf(requiredSheets, "A9");
                n -= 2;
                requiredSheets[index] = "";
            }
            if (n >= 1)
            {
                int index = Array.IndexOf(requiredSheets, "A10");
                n -= 1;
                requiredSheets[index] = "";
            }
        }

        for (int i = 0; i < requiredSheets.Length; i++)
        {
            if (requiredSheets[i] != string.Empty)
            {
                Console.WriteLine(requiredSheets[i]);
            }
        }
    }
}