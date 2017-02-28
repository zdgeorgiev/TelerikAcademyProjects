using System;
using System.Text;

class OnesAndZeros
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();

        string asBinary = Convert.ToString(number, 2);

        int additionLeadingZeros = 16 - asBinary.Length;

        if (additionLeadingZeros > 0)
        {
            for (int i = 0; i < additionLeadingZeros; i++)
            {
                asBinary = asBinary.Insert(0, "0");
            }
        }
        else
        {
            asBinary = asBinary.Substring(additionLeadingZeros * -1);
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                if (asBinary[j] == '1')
                {
                    AddCurrentRepresentaion(1, i + 1, result);
                }
                else
                {
                    AddCurrentRepresentaion(0, i + 1, result);
                }

                if (j != 15)
                {
                    result.Append(".");
                }
            }

            result.AppendLine();
        }

        result.Length--;
        Console.WriteLine(result.ToString());
    }

    private static void AddCurrentRepresentaion(int number, int iteration, StringBuilder result)
    {
        if (number == 1)
        {
            switch (iteration)
            {
                case 1: result.Append(".#."); break;
                case 2: result.Append("##."); break;
                case 3: result.Append(".#."); break;
                case 4: result.Append(".#."); break;
                case 5: result.Append("###"); break;

                default:
                    break;
            }
        }
        else
        {
            switch (iteration)
            {
                case 1: result.Append("###"); break;
                case 2: result.Append("#.#"); break;
                case 3: result.Append("#.#"); break;
                case 4: result.Append("#.#"); break;
                case 5: result.Append("###"); break;

                default:
                    break;
            }
        }
    }
}