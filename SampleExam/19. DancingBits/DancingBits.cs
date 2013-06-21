using System;
using System.Text;

class DancingBits
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string binaryRepresentation = Convert.ToString(number, 2);
            result.Append(binaryRepresentation);
        }

        //Console.WriteLine(result.ToString());

        int kSequence = 0;

        for (int i = 0; i < result.Length; i++)
        {
            int currentLine = 0;

            while (i < result.Length && result[i] == '1')
            {
                currentLine++;
                i++;
            }

            if (currentLine == k)
            {
                kSequence++;
            }
        }

        for (int i = 0; i < result.Length; i++)
        {
            int currentLine = 0;

            while (i < result.Length && result[i] == '0')
            {
                currentLine++;
                i++;
            }

            if (currentLine == k)
            {
                kSequence++;
            }
        }

        Console.WriteLine(kSequence);
    }
}

//5
//13
//14
//2
//4
//15
//16
//9
//7
//5
//2
//3
//5
//1
//32

//3