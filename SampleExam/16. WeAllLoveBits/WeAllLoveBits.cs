using System;
using System.Text;

class WeAllLoveBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            ConvertToTheNewNumber();
        }
    }

    private static void ConvertToTheNewNumber()
    {
        int p = int.Parse(Console.ReadLine());
        char[] pRepresentation = Convert.ToString(p, 2).ToCharArray();
        //Console.WriteLine(pRepresentation);

        StringBuilder deltaPRepresentation = new StringBuilder();

        for (int i = 0; i < pRepresentation.Length; i++)
        {
            if (pRepresentation[i] == '1')
            {
                deltaPRepresentation.Append(0);
            }
            else
            {
                deltaPRepresentation.Append(1);
            }
        }

        int deltaP = Convert.ToInt32(deltaPRepresentation.ToString(), 2);

        //Console.WriteLine(deltaPRepresentation.ToString());
        //Console.WriteLine(Convert.ToInt32(deltaPRepresentation.ToString(), 2));

        StringBuilder lambdaPRepresentation = new StringBuilder();
        lambdaPRepresentation.Length = pRepresentation.Length;

        for (int i = 0; i < pRepresentation.Length; i++)
        {
            lambdaPRepresentation[lambdaPRepresentation.Length - i - 1] = pRepresentation[i];
        }

        int lambdaP = Convert.ToInt32(lambdaPRepresentation.ToString(), 2);

        //Console.WriteLine(lambdaP.ToString());
        //Console.WriteLine(Convert.ToInt32(lambdaPRepresentation.ToString(), 2));

        int pNew = (p ^ deltaP) & lambdaP;
        Console.WriteLine(pNew);
    }
}